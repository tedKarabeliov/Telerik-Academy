using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Students
{
    class Program
    {
        static void Main()
        {
            var students = TextParser.Parse("../../students.txt");
            var dictionary = new SortedDictionary<string, OrderedBag<Student>>();
            foreach (var student in students)
            {
                if (!dictionary.ContainsKey(student.Course))
                {
                    dictionary.Add(student.Course, new OrderedBag<Student>());
                }

                dictionary[student.Course].Add(student);
            }

            foreach (var item in dictionary)
            {
                Console.Write(item.Key + ": ");
                foreach (var student in item.Value)
                {
                    Console.Write(student.FirstName + " " + student.LastName + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
