using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }
        public List<int> Marks { get; set; }
        public Group Group { get; set; }

        public Student(
            string firstName, string lastName, int fn, string tel,
            string email, List<int> marks, int groupNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
            this.Group = group;
        }

    }
}
