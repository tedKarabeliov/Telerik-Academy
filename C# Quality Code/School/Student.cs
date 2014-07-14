using System;

namespace School
{
    public class Student
    {
        private string name;
        private int number;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is null or empty");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                if (value <= 10000 || value >= 99999)
                {
                    throw new ArgumentOutOfRangeException("Student number must be between 10000 and 99999");
                }
                this.Number = value;
            }
        }

        public Student(string name)
        {
            this.Name = name;
        }
    }
}
