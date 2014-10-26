using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class ManageBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.PanelDeleteBook.Visible = false;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                this.GridViewBooks.DataSource = db.Books.ToList();
                this.GridViewBooks.DataBind();
            }
        }

        protected void GridViewBooks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridViewBooks.PageIndex = e.NewPageIndex;
        }

        protected void ButtonDeleteBook_Command(object sender, CommandEventArgs e)
        {
            Session.Add("bookToDelete", int.Parse((string)(e.CommandArgument)));
            this.PanelDeleteBook.Visible = true;
        }

        protected void ButtonDeleteBook_Click(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                var bookToDelete = db.Books.Find(Session["bookToDelete"]);
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
        }

        protected void ButtonCancelDeleteBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageBooks.aspx");
        }

        protected void EditBook_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/Admin/EditBook?id=" + e.CommandArgument);
        }
    }
}