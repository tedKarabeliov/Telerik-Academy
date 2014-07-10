using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string Name { get; set; }
        public string GroupName { get; set; }

        public Student(string name, string groupName)
        {
            this.Name = name;
            this.GroupName = groupName;
        }
    }
}
