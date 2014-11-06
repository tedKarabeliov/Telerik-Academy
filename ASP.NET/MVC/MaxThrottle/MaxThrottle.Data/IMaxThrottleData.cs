using MaxThrottle.Data.Repositories;
using MaxThrottle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Data
{
    public interface IMaxThrottleData
    {
        IGenericRepository<Manufacturer> Manufacturers { get; }

        IGenericRepository<CarModel> CarModels { get; }

        IGenericRepository<Engine> Engines { get; }

        IGenericRepository<Car> Cars { get; }

        IGenericRepository<User> Users { get; }

        int SaveChanges();
    }
}
