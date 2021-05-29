using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TentMonitorDesk2021.Models;

namespace TentMonitorDesk2021
{
    public partial class TentData : DbContext
    {
        public TentData()
            : base("name=TentData")
        {
        }

        public virtual DbSet<TentLog> TentLogs { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<VPDLookup> VPDLookup { get; set; }
        public DbSet<TempRHRange> TempRHRange { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TentLog>()
                .Property(e => e.Temp)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TentLog>()
                .Property(e => e.Humid)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TentLog>()
                .Property(e => e.VPD)
                .HasPrecision(18, 4);
        }
    }
}
