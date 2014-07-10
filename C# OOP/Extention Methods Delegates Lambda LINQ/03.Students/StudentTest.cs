using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

//3. Write a method that from a given array of students
//finds all students whose first name is before its 
//last name alphabetically. Use LINQ query operators.

//4. Write a LINQ query that finds the first name and
//last name of all students with age between 18 and 24.

//5. Using the extension methods OrderBy() and ThenBy() with
//lambda expressions sort the students by first name and 
//last name in descending order. Rewrite the same with LINQ.


namespace Students
{
    class StudentTest
    {
        public static void SortStudents(List<Student> list)
        {
            var sortedStudents =
                from student in list
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            Console.WriteLine("Sorted students where their first name is before their last:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
       
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("pesho", "boss", 23));
            students.Add(new Student("gosho", "toshkov", 74));
            students.Add(new Student("misho", "u", 33));
            //Names sort
            SortStudents(students);

            //Age sort
            var ageList =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("Students sorted by age between 18 and 24");
            foreach (var student in ageList)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //Another name sort by lambda expressions
            var sortedByName =
                students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            Console.WriteLine("Sorted by lambda expressions:");
            foreach (var student in sortedByName)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //Same with LINQ
            var sortedByNameLINQ =
                from student in students
                orderby student.FirstName, student.LastName
                select student;

            Console.WriteLine("Sorted with LINQ:");
            foreach (var student in sortedByNameLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();


        }
    }
}
