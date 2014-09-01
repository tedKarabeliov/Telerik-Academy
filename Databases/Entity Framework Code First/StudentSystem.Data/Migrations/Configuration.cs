namespace StudentSystem.Data.Migrations
{
    using System.Linq;

    using System.Data.Entity.Migrations;
    using StudentSystem.Models;

    public class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            this.SeedCourses(context);
        }

        private void SeedCourses(StudentSystemDbContext context)
        {
            if (!context.Courses.Any())
            {
                var databasesCourse = new Course
                {
                    Name = "Databases",
                    Description = "Database Course",
                    Materials = "You will need a computer for this course",
                };
                context.Courses.Add(databasesCourse);

                var cSharpCourse = new Course
                {
                    Name = "C#",
                    Description = "C# Course",
                    Materials = "You will need a computer for this course",
                };
                context.Courses.Add(cSharpCourse);

                var javascriptCourse = new Course
                {
                    Name = "Javascript",
                    Description = "Javascript Course",
                    Materials = "You will need a computer for this course",
                };
                context.Courses.Add(javascriptCourse);
            }
        }
    }
}
