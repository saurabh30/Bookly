namespace webApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using webApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<webApi.Models.webApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(webApi.Models.webApiContext context)
        {
            context.Books.AddOrUpdate(
               new Book() { Id = 1, Name = "Pride and Prejudice" },
               new Book() { Id = 2, Name = "Wings of Fire" },
               new Book() { Id = 3, Name = "Journey"}
               );

            context.Customers.AddOrUpdate(
                new Customer { Id = 1, Name = "Iron Man"},
                new Customer { Id = 2, Name = "Elon Musk" },
                new Customer { Id = 3, Name = "Sheldon Cooper"}
                );
        }
    }
}
