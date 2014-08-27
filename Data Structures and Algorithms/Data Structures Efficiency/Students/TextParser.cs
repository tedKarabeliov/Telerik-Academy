using System;
using System.Collections.Generic;
using System.IO;

namespace Students
{
    public static class TextParser
    {
        public static Student[] Parse(string path)
        {
            var students = new List<Student>();
            var reader = new StreamReader(path);
            using (reader)
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var studentProps = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    var newStudent = new Student(studentProps[0], studentProps[1], studentProps[2]);
                    students.Add(newStudent);
                    line = reader.ReadLine();
                }
            }
            
            return students.ToArray();
        }
    }
}
