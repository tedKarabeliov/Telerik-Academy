using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private ICollection<Student> students;

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public Course()
        {
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count >= 30)
            {
                throw new ArgumentOutOfRangeException("Maximum students of this course is reached");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("Such student does not exist");
            }
            this.students.Remove(student);
        }

        public override string ToString()
        {
            var str = "";
            foreach (var student in this.students)
            {
                str += student.Name + " ";
            }
            return str.TrimEnd();
        }
    }
}
