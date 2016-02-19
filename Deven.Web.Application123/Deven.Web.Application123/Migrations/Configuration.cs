namespace Deven.Web.Application123.Migrations
{
    using Deven.Web.Application123.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Deven.Web.Application123.Context.AppDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Deven.Web.Application123.Context.AppDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Department> dList= new List<Department>()
            {
                new Department()
                {
                  Name="Marketing",
                  Job="Marketing",
                  Location="Jamal",
                   Status=true
                },

                new Department()
                {
                  Name="Sales",
                  Job="Sales",
                  Location="Dillibazar",
                   Status=true
                },
                 new Department()
                {
                  Name="Advertising",
                  Job="Advertising",
                  Location="Gongabu",
                  Status=false
                }
            };

            dList.ForEach(d =>
                {
                    context.Departments.Add(d);
                    context.SaveChanges();
                });

        }
    }
}
