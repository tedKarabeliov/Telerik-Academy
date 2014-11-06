using MaxThrottle.Data.Repositories;
using MaxThrottle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Data
{
    public class MaxThrottleData : IMaxThrottleData
    {
        private IMaxThrottleDbContext context;
        private IDictionary<Type, object> repositories;

        public MaxThrottleData()
            : this(new MaxThrottleDbContext())
        {
        }

        public MaxThrottleData(IMaxThrottleDbContext maxThrottleContext)
        {
            this.context = maxThrottleContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IGenericRepository<Car> Cars
        {
            get
            {
                return this.GetRepository<Car>();
            }
        }

        public IGenericRepository<Manufacturer> Manufacturers
        {
            get
            {
                return this.GetRepository<Manufacturer>();
            }
        }

        public IGenericRepository<CarModel> CarModels
        {
            get
            {
                return this.GetRepository<CarModel>();
            }
        }

        public IGenericRepository<Engine> Engines
        {
            get
            {
                return this.GetRepository<Engine>();
            }
        }

        public IGenericRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
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
