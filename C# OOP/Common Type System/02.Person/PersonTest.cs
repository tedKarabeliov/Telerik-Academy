using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create a class Person with two fields – name and age.
 * Age can be left unspecified (may contain null value.
 * Override ToString() to display the information of a
 * person and if age is not specified – to say so. Write
 * a program to test this functionality.
*/

namespace _02.Person
{
    public class PersonTest
    {
        static void Main()
        {
            Person personWithAge = new Person("Pesho");
            personWithAge.Age = 5;
            Console.WriteLine(personWithAge);

            Person personWithoutAge = new Person("Misho");
            Console.WriteLine(personWithoutAge);
        }
    }
}
