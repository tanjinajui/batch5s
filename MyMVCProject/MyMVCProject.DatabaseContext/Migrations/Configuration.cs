namespace MyMVCProject.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMVCProject.DatabaseContext.DatabaseContext.SupplierDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyMVCProject.DatabaseContext.DatabaseContext.SupplierDbContext";
        }

        protected override void Seed(MyMVCProject.DatabaseContext.DatabaseContext.SupplierDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
