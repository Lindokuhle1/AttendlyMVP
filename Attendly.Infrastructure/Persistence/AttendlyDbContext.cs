using Attendly.Domain;
using Attendly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendly.Infrastructure.Persistence
{
    public class AttendlyDbContext : DbContext
    {
        public AttendlyDbContext(DbContextOptions<AttendlyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Domain.AttendanceRecord> AttendanceRecords => Set<Domain.AttendanceRecord>();
        public DbSet<AppUser> AppUsers => Set<AppUser>();
        public DbSet<PosTransaction> PosTransactions => Set<PosTransaction>();
        public DbSet<POSItem> POSItems => Set<POSItem>();
        public DbSet<Sale> Sales => Set<Sale>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entities
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<Domain.AttendanceRecord>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne<User>().WithMany().HasForeignKey(e => e.UserId);
            });

            modelBuilder.Entity<POSItem>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne<POSItem>().WithMany().HasForeignKey(e => e.POSItemId);
            });
        }

    }
}
