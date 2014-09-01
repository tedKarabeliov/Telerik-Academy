namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Models;
    using StudentSystem.Data.Migrations;

    public class StudentSystemDbContext : DbContext, IStudentSystemDbContext
    {
        public StudentSystemDbContext()
            : base("StudentSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public void Entry()
        {

        }

    }
}
