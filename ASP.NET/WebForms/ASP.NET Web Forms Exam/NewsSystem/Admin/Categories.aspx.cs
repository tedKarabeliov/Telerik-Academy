using ErrorHandlerControl;
using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PanelEditCategory.Visible = false;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new NewsSystemDbContext())
            {
                this.GridViewCategories.DataSource = db.Categories.ToList();
                this.GridViewCategories.DataBind();
            }
        }

        protected void GridViewCategories_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridViewCategories.PageIndex = e.NewPageIndex;
        }

        protected void GridViewCategories_Sorting(object sender, GridViewSortEventArgs e)
        {
            using (var db = new NewsSystemDbContext())
            {
                GridViewCategories.DataSource = db.Categories.OrderBy(c => e.SortExpression).ToList();
                GridViewCategories.DataBind();
            }
        }

        protected void ButtonCreateCategory_Click(object sender, EventArgs e)
        {
            var categoryName = this.TextBoxCreateCategory.Text;

            if (categoryName == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Category name must not be empty");
                Response.Redirect("~/Admin/Categories.aspx");
                return;
            }

            if (categoryName.Length > 50)
            {
                ErrorSuccessNotifier.AddErrorMessage("Too long category name");
                Response.Redirect("~/Admin/Categories.aspx");
                return;
            }

            using (var db = new NewsSystemDbContext())
            {
                if (db.Categories.FirstOrDefault(c => c.Name == categoryName) != null)
                {
                    ErrorSuccessNotifier.AddErrorMessage("Categories must be unique");
                }
                else
                {
                    db.Categories.Add(new Category
                    {
                        Name = categoryName
                    });

                    db.SaveChanges();
                }
            }
        }

        protected void ButtonOpenEditPanel_Command(object sender, CommandEventArgs e)
        {
            this.Session.Add("categoryIdToEdit", e.CommandArgument);

            this.PanelEditCategory.Visible = true;
        }

        protected void ButtonEditCategory_Click(object sender, EventArgs e)
        {
            var categoryName = this.TextBoxEditCategory.Text;

            if (categoryName == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Category name must not be empty");
                Response.Redirect("~/Admin/Categories.aspx");
                return;
            }

            var categoryId = int.Parse((string)this.Session["categoryIdToEdit"]);

            using (var db = new NewsSystemDbContext())
            {
                var categoryToEdit = db.Categories.FirstOrDefault(c => c.Id == categoryId);
                categoryToEdit.Name = this.TextBoxEditCategory.Text;
                db.SaveChanges();
            }
        }

        protected void ButtonDeleteCategory_Command(object sender, CommandEventArgs e)
        {
            var categoryId = int.Parse((string)e.CommandArgument);

            using (var db = new NewsSystemDbContext())
            {
                var categoryToDelete = db.Categories.FirstOrDefault(c => c.Id == categoryId);
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
            }
        }
    }
}