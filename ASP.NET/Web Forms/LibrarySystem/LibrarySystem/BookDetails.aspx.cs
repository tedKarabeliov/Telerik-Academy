using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected Book Book { get; set; }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (var db = new Models.LibrarySystemEntities())
            {
                var bookId = int.Parse(this.Request.QueryString["id"]);
                var bookToView = db.Books.Find(bookId);

                this.Book = bookToView;
            }
        }
    }
}