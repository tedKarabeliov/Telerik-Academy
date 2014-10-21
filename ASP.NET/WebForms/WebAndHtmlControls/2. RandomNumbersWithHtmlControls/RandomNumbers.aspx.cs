using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.RandomNumbersWithHtmlControls
{
    public partial class RandomNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InputResult_Click()
        {
            var random = new Random();

            var startRange = int.Parse(this.InputStartRange.Value);
            var endRange = int.Parse(this.InputEndRange.Value);

            this.SpanResult.InnerText = random.Next(startRange, endRange).ToString();
        }
    }
}