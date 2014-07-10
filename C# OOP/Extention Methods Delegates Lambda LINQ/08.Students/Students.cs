using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18.Create a program that extracts all students grouped
//by GroupName and then prints them to the console. Use LINQ.

//19.Rewrite the previous using extension methods.

namespace Students
{
    public class Students
    {
        static void Main()
        { 
            List<Student> sampleStudents = new List<Student>
            {
                new Student("Pesho", "Red"),
                new Student("Misho", "Blue"),
                new Student("Gosho", "Green"),
                new Student("Tosho", "Red"),
                new Student("Munio", "Red")
            };

            //With LINQ
            var grouped =
                from student in sampleStudents
                group student by student.GroupName into result
                select result;

            Console.WriteLine("Grouped with LINQ");
            foreach (var result in grouped)
            {
                Console.WriteLine("Grouped with " + result.Key);
                foreach (var student in result)
                {
                    Console.WriteLine(student.Name);
                }
            }
            Console.WriteLine();

            //With extention methods

            var groupedExt = sampleStudents.GroupBy((student) => student.GroupName)
                .Select(result => result);

            Console.WriteLine("Grouped with expression methods");
            foreach (var result in groupedExt)
            {
                Console.WriteLine("Grouped with " + result.Key);
                foreach (var student in result)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}
