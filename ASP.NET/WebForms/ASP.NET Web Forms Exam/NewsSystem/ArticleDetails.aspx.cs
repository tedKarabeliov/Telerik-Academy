using NewsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace NewsSystem
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Article FormViewArticleDetails_GetItem([QueryString("id")]int? Id)
        {
            using (var db = new NewsSystemDbContext())
            {
                if (Id == null)
                {
                    Response.Redirect("~/");
                }

                var article = db.Articles
                    .Include(a => a.Category)
                    .Include(a => a.User)
                    .Include(a => a.Likes)
                    .FirstOrDefault(a => a.Id == Id);
                return article;
            }
        }
    }
}