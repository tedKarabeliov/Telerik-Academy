using MaxThrottle.Data.Migrations;
using MaxThrottle.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Data
{
    public class MaxThrottleDbContext : IdentityDbContext<User>, IMaxThrottleDbContext
    {
        public MaxThrottleDbContext()
            : base("MaxThrottleConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<MaxThrottleDbContext>(
                new MigrateDatabaseToLatestVersion<MaxThrottleDbContext, Configuration>());
        }

        public static MaxThrottleDbContext Create()
        {
            return new MaxThrottleDbContext();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }

        public virtual IDbSet<CarModel> CarModels { get; set; }

        public virtual IDbSet<Engine> Engines { get; set; }

        public virtual IDbSet<Car> Cars { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
