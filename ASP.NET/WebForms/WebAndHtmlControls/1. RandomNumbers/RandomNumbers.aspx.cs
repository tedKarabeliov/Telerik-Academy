using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.RandomNumbers
{
    public partial class RandomNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            var random = new Random();

            var startRange = int.Parse(this.TextBoxStartRange.Text);
            var endRange = int.Parse(this.TextBoxEndRange.Text);

            this.LabelResult.Text = random.Next(startRange, endRange).ToString();
        }
    }
}