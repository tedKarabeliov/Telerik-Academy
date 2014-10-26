using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new LibrarySystemEntities())
            {
                this.ListViewCategories.DataSource = db.Categories.ToList();
                this.ListViewCategories.DataBind();
            }
        }

        protected void BookDetails_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("~/BookDetails?id=" + e.CommandArgument);
        }

        protected void ButtonSearchBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Search?q=" + this.TextBoxSearchBooks.Text);
        }
    }
}