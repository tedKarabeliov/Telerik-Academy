using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class EditBook : System.Web.UI.Page
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

        protected void LinkButtonSaveBook_Click(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                var id = int.Parse(Request.QueryString["id"]);
                var bookToEdit = db.Books.Find(id);

                if (!String.IsNullOrEmpty(this.TextBoxTitle.Text))
                {
                    bookToEdit.Title = this.TextBoxTitle.Text;
                }

                if (!String.IsNullOrEmpty(this.TextBoxAuthor.Text))
                {
                    bookToEdit.Authors = this.TextBoxAuthor.Text;
                }

                if (!String.IsNullOrEmpty(this.TextBoxISBN.Text))
                {
                    bookToEdit.ISBN = this.TextBoxISBN.Text;
                }

                if (!String.IsNullOrEmpty(this.TextBoxURL.Text))
                {
                    bookToEdit.URL = this.TextBoxURL.Text;
                }

                if (!String.IsNullOrEmpty(this.TextAreaDescription.Text))
                {
                    bookToEdit.Description = this.TextAreaDescription.Text;
                }

                if (this.DropDownListCategories.SelectedItem.Text != bookToEdit.Category.Name)
                {
                    bookToEdit.Category.Name = this.DropDownListCategories.SelectedItem.Text;
                }

                db.SaveChanges();
            }

            Response.Redirect("~/Admin/ManageBooks.aspx");
        }

        protected void LinkButtonCancelSaveBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageBooks.aspx");
        }
    }
}