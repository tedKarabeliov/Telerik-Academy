using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }

        public Student(string firstName, string lastName, string course)
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
            this.Course = course.Trim();
        }

        public int CompareTo(Student other)
        {
            var comparedLastNames = this.LastName.CompareTo(other.LastName);
            if (comparedLastNames == 0)
            {
                var comparedFirstNames = this.FirstName.CompareTo(other.FirstName);
                return comparedFirstNames;
            }
            return comparedLastNames;
        }
    }
}
