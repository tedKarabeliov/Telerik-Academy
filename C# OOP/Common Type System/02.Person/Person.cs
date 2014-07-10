using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            string result = "Person: " + this.Name + '\n';
            if (this.Age != null)
            {
                result += "Age: " + this.Age;
            }
            else
            {
                result += "Age not specified";
            }
            return result;
        }
    }
}
