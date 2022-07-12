using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Demo.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<Vessel> Vessels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vessel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.CallSign)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.MMSI)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.IMOID)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.Flag)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.Beam)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.RegPort)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.DeadWeightTonnage)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.VesselType)
                .IsFixedLength();

            modelBuilder.Entity<Vessel>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.LatestPort)
                .IsUnicode(false);

            modelBuilder.Entity<Vessel>()
                .Property(e => e.Url)
                .IsUnicode(false);
        }
    }
}
