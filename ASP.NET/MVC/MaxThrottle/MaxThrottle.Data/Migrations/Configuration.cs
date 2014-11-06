namespace MaxThrottle.Data.Migrations
{
    using MaxThrottle.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MaxThrottleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MaxThrottleDbContext context)
        {
            if (!context.Manufacturers.Any())
            {
                this.AssignUsersAndRoles(context);
                this.GetManufacturers(context).ForEach(m => context.Manufacturers.AddOrUpdate(m));
                context.SaveChanges();
                this.GetCarModels(context).ForEach(cm => context.CarModels.AddOrUpdate(cm));
                context.SaveChanges();
                this.GetEngines(context).ForEach(e => context.Engines.AddOrUpdate(e));
                context.SaveChanges();
                this.GetCars(context).ForEach(c => context.Cars.AddOrUpdate(c));

                context.SaveChanges();
            }
        }

        private void AssignUsersAndRoles(MaxThrottleDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "admin" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "pesho@pesho.com"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var adminUser = new User { UserName = "pesho@pesho.com", Email = "pesho@pesho.com", EmailConfirmed = true };

                manager.Create(adminUser, "peshopesho");
                manager.AddToRole(adminUser.Id, "admin");

                var regularUser = new User { UserName = "misho@misho.com", Email = "misho@misho.com", EmailConfirmed = true };
                manager.Create(regularUser, "mishomisho");
            }
        }

        private List<Manufacturer> GetManufacturers(MaxThrottleDbContext context)
        {
            return new List<Manufacturer>
            {
                new Manufacturer
                {
                    Name = "Renault"
                },
                new Manufacturer
                {
                    Name = "Subaru"
                },
                new Manufacturer
                {
                    Name = "Alfa Romeo"
                }
            };
        }

        private List<CarModel> GetCarModels(MaxThrottleDbContext context)
        {
            return new List<CarModel>
            {
                new CarModel
                {
                    Name = "Clio",
                    ManufacturerId = 1
                },
                new CarModel
                {
                    Name = "Megane",
                    ManufacturerId = 1
                },
                new CarModel
                {
                    Name = "Laguna",
                    ManufacturerId = 1
                },
                new CarModel
                {
                    Name = "Impreza",
                    ManufacturerId = 2
                },
                new CarModel
                {
                    Name = "Legacy",
                    ManufacturerId = 2
                },
                new CarModel
                {
                    Name = "Forester",
                    ManufacturerId = 2
                },
                new CarModel
                {
                    Name = "145",
                    ManufacturerId = 3
                },
                new CarModel
                {
                    Name = "146",
                    ManufacturerId = 3
                },
                new CarModel
                {
                    Name = "156",
                    ManufacturerId = 3
                },
                new CarModel
                {
                    Name = "166",
                    ManufacturerId = 3
                },
            };
        }

        private List<Engine> GetEngines(MaxThrottleDbContext context)
        {
            return new List<Engine>
            {
                new Engine
                {
                    Name = "1.5DCI",
                    HorsePower = 65,
                    NumberOfValves = 8,
                    EngineType = EngineType.Diesel,
                    CarModels = new List<CarModel>
                    {
                        context.CarModels.FirstOrDefault(cm => cm.Id == 1),
                    }
                },
                new Engine
                {
                    Name = "2.0 16V",
                    HorsePower = 169,
                    NumberOfValves = 16,
                    EngineType = EngineType.Petrol,
                    CarModels = new List<CarModel>
                    {
                        context.CarModels.FirstOrDefault(cm => cm.Id == 1),
                    }
                },
                new Engine
                {
                    Name = "2.5 16V",
                    HorsePower = 301,
                    NumberOfValves = 16,
                    EngineType = EngineType.Petrol,
                    CarModels = new List<CarModel>
                    {
                        context.CarModels.FirstOrDefault(cm => cm.Id == 4),
                    }
                },
                new Engine
                {
                    Name = "1.4 16V",
                    HorsePower = 100,
                    NumberOfValves = 16,
                    EngineType = EngineType.Petrol,
                    CarModels = new List<CarModel>
                    {
                        context.CarModels.FirstOrDefault(cm => cm.Id == 7),
                        context.CarModels.FirstOrDefault(cm => cm.Id == 8)
                    }
                }
            };
        }

        private List<Car> GetCars(MaxThrottleDbContext context)
        {
            return new List<Car>
            {
                new Car
                {
                    Price = 4400,
                    KilometersRan = 218000,
                    LeatherInterior = true,
                    YearOfProduction = 2000,
                    DateOfCreation = DateTime.Now,
                    ImageUrl = "../CarImages/1.jpg",
                    ManufacturerId = 1,
                    CarModelId = 1,
                    EngineId = 2,
                    UserId = context.Users.FirstOrDefault(u => u.UserName == "pesho@pesho.com").Id
                },
                new Car
                {
                    Price = 35000,
                    KilometersRan = 110000,
                    LeatherInterior = true,
                    YearOfProduction = 2008,
                    DateOfCreation = DateTime.Now,
                    ManufacturerId = 2,
                    CarModelId = 4,
                    EngineId = 3,
                    UserId = context.Users.FirstOrDefault(u => u.UserName == "pesho@pesho.com").Id
                },
                new Car
                {
                    Price = 1400,
                    KilometersRan = 1000000,
                    YearOfProduction = 1997,
                    DateOfCreation = DateTime.Now,
                    ManufacturerId = 3,
                    CarModelId = 7,
                    EngineId = 4,
                    UserId = context.Users.FirstOrDefault(u => u.UserName == "pesho@pesho.com").Id
                }
            };
        }
    }
}
