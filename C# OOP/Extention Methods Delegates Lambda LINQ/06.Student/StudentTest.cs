using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9. Create a class student with properties FirstName, LastName, FN, Tel, Email,
//Marks (a List<int>), GroupNumber. Create a List<Student> with sample students.
//Select only the students that are from group number 2. Use LINQ query.
//Order the students by FirstName.

//10. Implement the previous using the same query expressed with extension methods.

//11. Extract all students that have email in abv.bg. Use string methods and LINQ.

//12. Extract all students with phones in Sofia. Use LINQ.

//13. Select all students that have at least one mark Excellent (6)
//into a new anonymous class that has properties – FullName and Marks. Use LINQ.

//14.Write down a similar program that extracts the students with exactly
//two marks "2". Use extension methods.

//15.Extract all Marks of the students that enrolled in 2006.
//(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

//16* Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property Group in the Student class. Extract all students
//from "Mathematics" department. Use the Join operator.

namespace Students
{
    public class StudentTest
    {
        private static void ExtractWithSpecificEmails(List<Student> sampleStudents)
        {
            Console.WriteLine("Extracted with e-mails of \"abv.bg\"");
            var extractedWithSpecificEmails =
                from student in sampleStudents
                where student.Email.IndexOf("@abv.bg") != -1
                select student;

            foreach (var student in extractedWithSpecificEmails)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        private static void ExtractWithPhonesInSofia(List<Student> sampleStudents)
        {
            var extractedWithPhonesInSofia =
                from student in sampleStudents
                where student.Tel.Length > 2 && student.Tel[0] == '0' && student.Tel[1] == '2'
                select student;

            Console.WriteLine("Student(s)'s phones in Sofia:");
            foreach (var student in extractedWithPhonesInSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        private static void ExtractWithExcellentMark(List<Student> sampleStudents)
        {
            Console.WriteLine("Students with at least 1 excellent mark:");
            var extractedWithExcellentMark =
                from student in sampleStudents
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in extractedWithExcellentMark)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            //using LINQ
            Console.WriteLine("Using LINQ:\n");

            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student(
                "Pesho", "Peshov", 449706, "0882123321", "peshov@abv.bg", new List<int>() { 2, 3, 2, 4, 3, 3 }, 4, new Group(1, "Mathematics")));
            sampleStudents.Add(new Student(
                "Misho", "Mishov", 449706, "02856123123", "mishov@abv.bg", new List<int>() { 3, 4, 3, 2, 2, 5 }, 5, new Group(2, "Literature")));
            sampleStudents.Add(new Student(
                "Gosho", "Goshov", 449752, "0882345543", "goshov@mail.bg", new List<int>() { 5, 6, 5, 6, 6, 5 }, 2, new Group(1, "Mathematics")));
            sampleStudents.Add(new Student(
                "Tosho", "Toshov", 449741, "0882456654", "toshov@abv.bg", new List<int>() { 2, 6, 2, 3, 5, 6 }, 2, new Group(4, "Biology")));


            //Selected by group number 2
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

            //Sorted by Firstname
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

            //using extention methods
            Console.WriteLine("Using extention methods:\n");

            sampleStudents.SelectByGroup2();
            sampleStudents.SortByFirstName();

            //Extracted with e-mails of abv.bg
            ExtractWithSpecificEmails(sampleStudents);

            //Extracted with phones in Sofia
            ExtractWithPhonesInSofia(sampleStudents);

            //Extracted with excellent mark
            ExtractWithExcellentMark(sampleStudents);

            //Extracted with "2" marks
            sampleStudents.ExtractWith2Marks();

            //Extracted enrolled in 2006

            var enrolled2006 =
                from student in sampleStudents
                where student.FN.ToString().Length >= 6 && student.FN.ToString().Substring(4, 2) == "06"
                select student;

            Console.WriteLine("Enrolled in 2006");
            foreach (var student in enrolled2006)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            //Extracted with Mathematics Department

            //Create second collection
            List<string> departments = new List<string>();

            for (int i = 0; i < sampleStudents.Count; i++)
            {
                if (!departments.Contains(sampleStudents[i].Group.DepartmentName))
                {
                    departments.Add(sampleStudents[i].Group.DepartmentName);
                }
            }

            var fromMathematicsDepartment =
                from student in sampleStudents
                join currentDepartment in departments on student.Group.DepartmentName equals currentDepartment
                where student.Group.DepartmentName == "Mathematics"
                select student;

            Console.WriteLine("Students from Mathematics Department");
            foreach (var student in fromMathematicsDepartment)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
                
        }
    }
}
