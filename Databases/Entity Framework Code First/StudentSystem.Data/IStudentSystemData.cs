namespace StudentSystem.Data
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public interface IStudentSystemData
    {
        IGenericRepository<Student> Students { get; }

        IGenericRepository<Course> Courses { get; }

        IGenericRepository<Homework> Homeworks { get; }
    }
}
