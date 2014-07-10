using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class StudentExtentions
    {
        public static void SelectByGroup2(
            this List<Student> sampleStudents)
        {
            var selectedStudents =
                from student in sampleStudents
                where student.GroupNumber == 2
                select student;

            Console.WriteLine("Selected by group number 2:");
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        public static void SortByFirstName(
            this List<Student> sampleStudents)
        {
            var sortedStudents =
                from student in sampleStudents
                orderby student.FirstName
                select student;

            Console.WriteLine("Sorted by FirstName:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        public static void ExtractWith2Marks(
            this List<Student> sampleStudents)
        {
           var selectedStudents =
               from student in sampleStudents
               where student.Marks.Count(x => x == 2) == 2
               select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

           Console.WriteLine("Student with 2 marks \"2\"");
           foreach (var student in selectedStudents)
           {
               Console.WriteLine(student.FullName);
           }
           Console.WriteLine();
        }
    }
}
