namespace StudentSystem.ConsoleClient
{
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Models;

    public class ConsoleClient
    {
        public static void Main()
        {
            var studentSystem = new StudentSystemData();

            var student = new Student
            {
                Name = "Misho"
            };
            studentSystem.Students.Add(student);
            studentSystem.SaveChanges();
        }
    }
}
