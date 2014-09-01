using System.Collections.Generic;
namespace StudentSystem.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Materials { get; set; }

        public int? HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}