using MAEMS.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MAEMS.Web.Infrastructure
{
    public class EventDb : DbContext, IEventDataSource
    {
        public EventDb(): base("MAEMS.Web")
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        IQueryable<Staff> IEventDataSource.Staffs => Staffs;

        IQueryable<Event> IEventDataSource.Events => Events;
    }
}