using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Repository.Entities;

namespace TestAPI.Repository
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Notification entity
            modelBuilder.Entity<NotificationEntity>()
                .HasKey(n => n.Id);

            modelBuilder.Entity<NotificationEntity>()
                .Property(n => n.UserId)
                .IsRequired();

            modelBuilder.Entity<NotificationEntity>()
                .Property(n => n.Content)
                .HasMaxLength(500)
                .IsRequired();

            modelBuilder.Entity<NotificationEntity>()
                .Property(n => n.SentDate)
                .IsRequired();

            modelBuilder.Entity<NotificationEntity>()
                .Property(n => n.Status)
                .IsRequired();

            modelBuilder.Entity<NotificationEntity>()
                .HasOne(nt => nt.NotificationType)
                .WithMany()
                .HasForeignKey(n => n.NotificationTypeId)
                .IsRequired();

            // Configure NotificationType entity
            modelBuilder.Entity<NotificationTypeEntity>()
                .HasKey(nt => nt.Id);

            modelBuilder.Entity<NotificationTypeEntity>()
                .Property(nt => nt.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<NotificationTypeEntity>()
                .Property(nt => nt.Description)
                .HasMaxLength(250);
        }
    }

}
