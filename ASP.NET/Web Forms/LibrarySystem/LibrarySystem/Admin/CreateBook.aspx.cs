using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class CreateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                this.DropDownListCategories.DataSource = db.Categories.ToList().Select(c => new
                {
                    c.CategoryId,
                    c.Name
                });
                this.DropDownListCategories.DataBind();
            }
        }

        protected void LinkButtonCreateBook_Click(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                var bookToCreate = new Book
                {
                    Title = this.TextBoxTitle.Text,
                    Authors = this.TextBoxAuthor.Text,
                    ISBN = this.TextBoxISBN.Text,
                    URL = this.TextBoxURL.Text,
                    Description = this.TextAreaDescription.Text,
                    CategoryId = int.Parse(this.DropDownListCategories.SelectedValue)
                };

                db.Books.Add(bookToCreate);
                db.SaveChanges();
            }

            Response.Redirect("~/Admin/ManageBooks.aspx");
        }

        protected void LinkButtonCancelCreateBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageBooks.aspx");
        }
    }
}