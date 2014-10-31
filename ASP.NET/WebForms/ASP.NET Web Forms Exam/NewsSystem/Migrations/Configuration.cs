namespace NewsSystem.Migrations
{
    using NewsSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NewsSystem;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "NewsSystem.Models.NewsSystemDbContext";
        }

        protected override void Seed(NewsSystemDbContext context)
        {
            
        }
    }
}
