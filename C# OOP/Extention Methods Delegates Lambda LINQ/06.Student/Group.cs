using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int groupNumber, string departamentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departamentName;
        }
    }
}
