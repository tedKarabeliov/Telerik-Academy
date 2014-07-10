namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get { return this.lab; }
            set { this.lab = value; }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Lab=" + this.Lab;
            return result;
        }
    }
}
