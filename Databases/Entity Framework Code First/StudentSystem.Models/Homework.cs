using System;
using System.Collections.Generic;
namespace StudentSystem.Models
{
    public class Homework
    {
        public Homework()
        {
            this.Students = new HashSet<Student>();
            this.Courses = new HashSet<Course>();
        }

        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
