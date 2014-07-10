namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;
    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private IList<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public ITeacher Teacher
        {
            get { return this.teacher; }
            set { this.teacher = value; }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + ": " + "Name=" + this.Name + "; ");
            if (this.Teacher != null)
            {
                result.Append("Teacher=" + this.Teacher.Name + "; ");
            }
            if (this.topics.Count != 0)
            {
                result.Append("Topics=[");
                for (int i = 0; i < this.topics.Count; i++)
                {
                    result.Append(this.topics[i] + ", ");
                }
                result.Remove(result.Length - 2, 2);
                result.Append("]");
                result.Append("; ");
            }

            return result.ToString();
        }
    }
}
