using Lab3_DWD278_JR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Lab3_DWD278_JR.DataAccess
{
    public class EventManagerContext : DbContext
    {
        public EventManagerContext() : base("EventManagerContext")
        {
        }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}