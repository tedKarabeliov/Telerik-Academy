using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5.Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOne_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "1";
        }

        protected void ButtonTwo_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "2";
        }

        protected void ButtonThree_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "3";
        }

        protected void ButtonFour_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "4";
        }

        protected void ButtonFive_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "5";
        }

        protected void ButtonSix_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "6";
        }

        protected void ButtonSeven_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "7";
        }

        protected void ButtonEight_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "8";
        }

        protected void ButtonNine_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "9";
        }

        protected void ButtonZero_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "0";
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "+";
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "-";
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "*";
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += "/";
        }

        protected void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            var input = this.TextBoxDisplay.Text;
            if (input == string.Empty)
            {
                this.TextBoxDisplay.Text = String.Empty;
                return;
            }

            double number;
            if (!(double.TryParse(input, out number)))
            {
                this.TextBoxDisplay.Text = String.Empty;
                return;
            }

            var result = Math.Sqrt(number);
            this.TextBoxDisplay.Text = result.ToString();
        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            var expression = this.TextBoxDisplay.Text;
            var result = new DataTable().Compute(expression, null).ToString();
            this.TextBoxDisplay.Text = result;
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text = String.Empty;
        }
    }
}