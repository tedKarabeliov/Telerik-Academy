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
    public partial class CreateArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var db = new NewsSystemDbContext())
                {
                    this.DropDownListCategories.DataSource = db.Categories.ToList().Select(c => new
                    {
                        c.Id,
                        c.Name
                    });
                    this.DropDownListCategories.DataBind();
                }
            }
        }

        protected void ButtonCreateArticle_Click(object sender, EventArgs e)
        {
            var title = this.TextBoxTitle.Text;
            var content = this.TextBoxContent.Text;

            if (title == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Title name must not be empty");
                Response.Redirect("~/Admin/CreateArticle.aspx");
                return;
            }

            if (title.Length > 50)
            {
                ErrorSuccessNotifier.AddErrorMessage("Too long title name");
                Response.Redirect("~/Admin/CreateArticle.aspx");
                return;
            }

            if (content == String.Empty)
            {
                ErrorSuccessNotifier.AddErrorMessage("Content name must not be empty");
                Response.Redirect("~/Admin/CreateArticle.aspx");
                return;
            }

            var categoryId = int.Parse(this.DropDownListCategories.SelectedValue);
            var userName = this.User.Identity.Name;

            using (var db = new NewsSystemDbContext())
            {
                var userId = db.Users.FirstOrDefault(u => u.UserName == userName).Id;

                db.Articles.Add(new Article
                {
                    Title = title,
                    CategoryId = categoryId,
                    Content = content,
                    DateCreated = DateTime.Now,
                    UserId = userId
                });

                db.SaveChanges();
            }

            Response.Redirect("~/Admin/Articles.aspx");
        }

        protected void ButtonCancelCreateArticle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Articles.aspx");
        }
    }
}