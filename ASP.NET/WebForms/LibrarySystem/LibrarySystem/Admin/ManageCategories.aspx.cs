using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibrarySystem.Models;
using System.Data.Entity.Infrastructure;

namespace LibrarySystem.Admin
{
    public partial class ManageCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PanelEditCategory.Visible = false;
            this.PanelDeleteCategory.Visible = false;
            this.PanelCreateCategory.Visible = false;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                this.GridViewCategories.DataSource = db.Categories.ToList();
                this.GridViewCategories.DataBind();
            }
        }

        protected void GridViewCategories_PageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            this.GridViewCategories.PageIndex = e.NewPageIndex;
        }

        protected void Edit_Command(object sender, CommandEventArgs e)
        {
            Session.Add("categoryToEdit", int.Parse((string)(e.CommandArgument)));
            this.PanelEditCategory.Visible = true;
        }

        protected void ButtonSaveCategory_Click(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                var categoryToEdit = db.Categories.Find(Session["categoryToEdit"]);
                categoryToEdit.Name = this.TextBoxEditCategory.Text;
                db.SaveChanges();
                this.PanelEditCategory.Visible = false;
            }
        }

        protected void ButtonCancelEditCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageCategories.aspx");
        }

        protected void Delete_Command(object sender, CommandEventArgs e)
        {
            Session.Add("categoryToDelete", int.Parse((string)(e.CommandArgument)));
            this.PanelDeleteCategory.Visible = true;
        }

        protected void ButtonDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LibrarySystemEntities())
                {
                    var categoryToDelete = db.Categories.Find(Session["categoryToDelete"]);
                    db.Categories.Remove(categoryToDelete);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Response.Write("<h1>Cannot delete category! There are books in this category</h1>");
            }
            
        }

        protected void ButtonCancelDeleteCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageCategories.aspx");
        }

        protected void LinkButtonCreateCategory_Click(object sender, EventArgs e)
        {
            this.PanelCreateCategory.Visible = true;
        }

        protected void ButtonCreateCategory_Click(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                db.Categories.Add(new Category
                    {
                        Name = this.TextBoxCreateCategory.Text
                    });

                db.SaveChanges();
            }
        }

        protected void ButtonCancelCreateCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageCategories.aspx");
        }
    }
}