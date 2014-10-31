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
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PanelEditArticle.Visible = false;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new NewsSystemDbContext())
            {
                var sortMethod = Request.QueryString["sort"];

                if (sortMethod != null)
                {
                    if (sortMethod == "title")
                    {
                        this.ListViewArticles.DataSource = db.Articles.OrderBy(a => a.Title).ToList();
                    }
                    else if (sortMethod == "date")
                    {
                        this.ListViewArticles.DataSource = db.Articles.OrderBy(a => a.DateCreated).ToList();
                    }
                    else if (sortMethod == "category")
                    {
                        this.ListViewArticles.DataSource = db.Articles.OrderBy(a => a.Category.Name).ToList();
                    }
                    else if (sortMethod == "likes")
                    {
                        this.ListViewArticles.DataSource = db.Articles.OrderBy(a => a.Likes.Count).ToList();
                    }
                }
                else
                {
                    this.ListViewArticles.DataSource = db.Articles.ToList();
                }

                this.ListViewArticles.DataBind();
            }
        }

        protected void ButtonEditArticle_Command(object sender, CommandEventArgs e)
        {
            this.Session.Add("articleIdToEdit", e.CommandArgument);

            using (var db = new NewsSystemDbContext())
            {
                this.DropDownListCategories.DataSource = db.Categories.ToList().Select(c => new
                {
                    c.Id,
                    c.Name
                });
                this.DropDownListCategories.DataBind();
            }

            this.PanelEditArticle.Visible = true;
        }

        protected void ButtonDeleteArticle_Command(object sender, CommandEventArgs e)
        {
            var articleId = int.Parse((string)e.CommandArgument);

            using (var db = new NewsSystemDbContext())
            {
                var articleToDelete = db.Articles.FirstOrDefault(a => a.Id == articleId);
                db.Articles.Remove(articleToDelete);

                db.SaveChanges();
            }
        }

        protected void ButtonEditArticle_Click(object sender, EventArgs e)
        {
            var articleId = int.Parse((string)this.Session["articleIdToEdit"]);
            var title = this.TextBoxTitle.Text;
            var content = this.TextBoxContent.Text;

            if (title == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Title must not be empty");
                Response.Redirect("~/Admin/Articles.aspx");
                return;
            }

            if (content == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Content must not be empty");
                Response.Redirect("~/Admin/Articles.aspx");
                return;
            }


            var categoryId = int.Parse(this.DropDownListCategories.SelectedValue);

            using (var db = new NewsSystemDbContext())
            {
                var articleToEdit = db.Articles.FirstOrDefault(a => a.Id == articleId);
                articleToEdit.Title = title;
                articleToEdit.Content = content;
                articleToEdit.CategoryId = categoryId;

                db.SaveChanges();
            }

            Response.Redirect("~/Admin/Articles.aspx");
        }

        protected void ButtonCancelEditArticle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Articles.aspx");
        }

        protected void SortByTitle_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Admin/Articles?sort=title");
        }

        protected void SortByDate_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Admin/Articles?sort=date");
        }

        protected void SortByCategory_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Admin/Articles?sort=category");
        }

        protected void SortByLikes_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Admin/Articles?sort=likes");
        }
    }
}