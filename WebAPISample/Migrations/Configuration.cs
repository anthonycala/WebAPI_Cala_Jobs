namespace WebAPISample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAPISample.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPISample.Models.ApplicationDbContext>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAPISample.Models.ApplicationDbContext context)
        {
            db.Movies.AddOrUpdate(
            new Models.Movie { Title = "The Departed", Genre = "Drama", Director = "Martin Scorsese" },
            new Models.Movie { Title = "The Dark Knight", Genre = "Drama", Director = "Christopher Nolan" },
            new Models.Movie { Title = "Inception", Genre = "Drama", Director = "Christopher Nolan" },
            new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", Director = "David Gordon Green" },
            new Models.Movie { Title = "Die Hard", Genre = "Action", Director = "John McTiernan" }
            );
            db.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
        }
    }
}
