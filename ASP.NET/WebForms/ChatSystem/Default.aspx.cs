using ChatSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new ChatSystemConnectionEntities())
            {
                this.ListViewMessages.DataSource = db.Messages.ToList();
                this.ListViewMessages.DataBind();
            }
        }

        protected void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            var messageToSend = this.TextBoxSendMessage.Text;
            var userName = User.Identity.Name;

            // TODO: Validation

            using (var db = new ChatSystemConnectionEntities())
            {
                var userId = db.AspNetUsers.FirstOrDefault(u => u.UserName == userName).Id;

                db.Messages.Add(new Message
                {
                    Text = messageToSend,
                    UserId = userId
                });

                db.SaveChanges();
            }
        }
    }
}