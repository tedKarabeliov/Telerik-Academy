using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new NewsSystemDbContext())
            {
                this.ListViewArticles.DataSource = db.Articles
                    .OrderByDescending(a => a.Likes.Count).Take(3).ToList();
                this.ListViewArticles.DataBind();

                this.ListViewCategories.DataSource = db.Categories.ToList();
                this.ListViewCategories.DataBind();
            }
        }

        protected void ShowArticleDetails_Command(object sender, CommandEventArgs e)
        {
            var articleId = (string)e.CommandArgument;

            Response.Redirect("~/ArticleDetails?id=" + articleId);
        }
    }
}