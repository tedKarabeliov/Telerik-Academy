using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentSystem.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }

        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Number { get; set; }

        public int? HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
