namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Models;
using System.Data.Entity.Infrastructure;
    
    public interface IStudentSystemDbContext
    {
        IDbSet<Student> Students { get; set; }

        IDbSet<Course> Courses { get; set; }

        IDbSet<Homework> Homeworks { get; set; }

        int SaveChanges();

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
