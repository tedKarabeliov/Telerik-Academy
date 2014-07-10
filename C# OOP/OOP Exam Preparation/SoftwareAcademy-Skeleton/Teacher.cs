namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;
    public class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Teacher: Name=" + this.name);
            if (this.courses.Count != 0)
            {
                result.Append("; Courses=[");
                for (int i = 0; i < this.courses.Count; i++)
                {
                    result.Append(this.courses[i].Name + ", ");
                }
                result.Remove(result.Length - 2, 2);
                result.Append("]");
            }

            return result.ToString();
        }
    }
}
