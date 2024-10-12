using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagementSystem.Domain.Entities;



namespace TaskManagementSystem.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Admin", PasswordHash = "hashed_password", Email = "admin@example.com", CreatedAt = DateTime.Now, Role = "Admin" },
                new User { Id = 2, Username = "User1", PasswordHash = "hashed_password", Email = "user1@example.com", CreatedAt = DateTime.Now, Role = "User" }
            );

            // Task entitisi üçün seed məlumatları
            modelBuilder.Entity<Domain.Entities.Task>().HasData(
                new Domain.Entities.Task { Id = 1, Title = "Task1", Description = "Description1", UserId = 1 },
                new Domain.Entities.Task { Id = 2, Title = "Task2", Description = "Description2", UserId = 2 }
            );
        }


        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
