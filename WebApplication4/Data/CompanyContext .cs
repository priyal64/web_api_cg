using Microsoft.EntityFrameworkCore;
using WebApplication4.Model;

namespace WebApplication4.Data
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Additional configurations using Fluent API

            // Department configuration
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);  // Prevent cascade delete

            // Employee configuration
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email)
                .IsUnique();

            // Seed data
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "HR", Description = "Human Resources Department" },
                new Department { DepartmentId = 2, Name = "IT", Description = "Information Technology Department" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@company.com",
                    Phone = "555-1234",
                    Salary = 75000M,
                    HireDate = new DateTime(2022, 1, 15),
                    DepartmentId = 2
                }
            );

        }
    }
}
