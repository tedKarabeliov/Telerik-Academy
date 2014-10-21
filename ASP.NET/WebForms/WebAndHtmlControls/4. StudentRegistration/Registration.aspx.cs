using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _4.StudentRegistration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            var firstName = this.TextBoxFirstName.Text;
            var lastName = this.TextBoxLastName.Text;
            var facultyNumber = this.TextBoxFacultyNumber.Text;
            var specialty = this.DropDownListSpecialties.SelectedValue;
            var univercity = this.DropDownListUnivercities.SelectedValue;

            var courses = new List<string>();
            foreach (var item in this.CheckBoxCourses.Items)
	        {
                var listItem = (ListItem)item;
                if (listItem.Selected)
                {
                    courses.Add(listItem.Text);
                }
	        }

            var namesOutput = new HtmlGenericControl("h1");
            namesOutput.InnerText = "Your name is " + firstName + " " + lastName;

            var facultyOutput = new HtmlGenericControl("p");
            facultyOutput.InnerText = "Faculty number: " + facultyNumber;

            var specialtyOutput = new HtmlGenericControl("p");
            specialtyOutput.InnerText = "Specialty: " + specialty;

            var univercityOutput = new HtmlGenericControl("p");
            univercityOutput.InnerText = "Univercity: " + univercity;

            var coursesOutput = new HtmlGenericControl("p");

            if (courses.Count == 0)
            {
                coursesOutput.InnerText = "none";
            }
            else
            {
                coursesOutput.InnerText = String.Join(", ", courses);
            }
            
            this.StudentRegistration.Controls.Add(namesOutput);
            this.StudentRegistration.Controls.Add(facultyOutput);
            this.StudentRegistration.Controls.Add(specialtyOutput);
            this.StudentRegistration.Controls.Add(univercityOutput);
            this.StudentRegistration.Controls.Add(coursesOutput);

        }
    }
}