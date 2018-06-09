namespace MAEMS.Web.Migrations
{
    using MAEMS.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.EventDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Infrastructure.EventDb context)
        {
            context.Events.AddOrUpdate(e => e.Name,
               new Event() { Name = "World Jiu Jitsu Championship" },
               new Event() { Name = "Pan American Jiu Jitsu Championship" },
               new Event() { Name = "American National Jiu Jitsu Championship" },
               new Event() { Name = "Atlanta Open Jiu Jitsu Championship" },
               new Event() { Name = "Seattle Open Jiu Jitsu Championship" }
               );
        }
    }
}
