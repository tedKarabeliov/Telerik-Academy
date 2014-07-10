using System;
using System.Collections.Generic;

namespace Phones
{
    public class Person
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string Number { get; set; }

        public Person(string name, string town, string number)
        {
            this.Name = name;
            this.Town = town;
            this.Number = number;
        }

        public override string ToString()
        {
            return this.Name + " | " + this.Town + " | " + this.Number;
        }
    }
}
