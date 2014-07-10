namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "Town=" + this.Town;
            return result;
        }
    }
}
