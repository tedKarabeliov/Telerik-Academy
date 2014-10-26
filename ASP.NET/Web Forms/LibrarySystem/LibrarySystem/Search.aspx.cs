using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var searchKeyword = Request.QueryString["q"];

            using (var db = new LibrarySystemEntities())
            {
                var foundBooks = db.Books.Where(
                    b => b.Title.Contains(searchKeyword) ||
                    b.Authors.Contains(searchKeyword)).ToList();

                this.ListViewBooks.DataSource = foundBooks;
                this.ListViewBooks.DataBind();
            }
        }
    }
}