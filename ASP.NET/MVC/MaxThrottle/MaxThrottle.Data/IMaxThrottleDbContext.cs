using MaxThrottle.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Data
{
    public interface IMaxThrottleDbContext
    {
        IDbSet<Manufacturer> Manufacturers { get; set; }

        IDbSet<CarModel> CarModels { get; set; }

        IDbSet<Engine> Engines { get; set; }

        IDbSet<Car> Cars { get; set; }

        int SaveChanges();

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
