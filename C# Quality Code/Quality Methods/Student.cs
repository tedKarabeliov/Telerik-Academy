using System;
using System.Text.RegularExpressions;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string OtherInfo { get; set; }

        public Student(string firstName, string lastName, string birthdate, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = DateTime.Parse(birthdate);
            this.OtherInfo = otherInfo;
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.BirthDate;
            DateTime secondDate = other.BirthDate;
            bool isOlder = firstDate > secondDate;
            return isOlder;
        }
    }
}
