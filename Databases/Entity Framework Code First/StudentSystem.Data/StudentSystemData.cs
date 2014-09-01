namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;

    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;
    
    
    public class StudentSystemData
    {
        private IStudentSystemDbContext context;
        private IDictionary<Type, object> repositories;

        public StudentSystemData()
            : this(new StudentSystemDbContext())
        {
        }

        public StudentSystemData(IStudentSystemDbContext studentSystemContext)
        {
            this.context = studentSystemContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Student> Students
        {
            get
            {
                return this.GetRepository<Student>();
            }
        }

        public IGenericRepository<Course> Courses
        {
            get
            {
                return this.GetRepository<Course>();
            }
        }

        public IGenericRepository<Homework> Homeworks
        {
            get
            {
                return this.GetRepository<Homework>();
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
