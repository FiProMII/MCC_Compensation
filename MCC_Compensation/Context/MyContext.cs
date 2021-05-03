using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<Compensation> Compensations { get; set; }
        public DbSet<CompensationRequest> CompensationRequests { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasOne(a => a.Employee)
                .WithOne(e => e.Account)
                .HasForeignKey<Employee>(a => a.NIK)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerNIK)
                .IsRequired(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.CompensationRequests)
                .WithOne(cr => cr.Employee)
                .HasForeignKey(cr => cr.NIK)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Position>()
                .HasOne(p => p.Department)
                .WithMany(d => d.Positions);

            modelBuilder.Entity<AccountRole>()
                .HasKey(ar => new { ar.NIK, ar.RoleID });

            modelBuilder.Entity<AccountRole>()
                .HasOne(a => a.Account)
                .WithMany(ar => ar.AccountRoles)
                .HasForeignKey(a => a.NIK)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AccountRole>()
                .HasOne(r => r.Role)
                .WithMany(ar => ar.AccountRoles)
                .HasForeignKey(r => r.RoleID);

            modelBuilder.Entity<CompensationRequest>()
                .HasMany(cr => cr.Approvals)
                .WithOne(a => a.CompensationRequest)
                .HasForeignKey(cr => cr.RequestID);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.CompensationRequest)
                .WithMany(cr => cr.Documents)
                .HasForeignKey(cr => cr.RequestID);

            modelBuilder.Entity<Compensation>()
                .HasMany(c => c.CompensationRequests)
                .WithOne(cr => cr.Compensation);

            modelBuilder.Entity<Status>()
                .HasMany(s => s.Approvals)
                .WithOne(a => a.Status);

            modelBuilder.Entity<Approval>()
                .HasOne(e => e.Employee)
                .WithMany(a => a.Approvals)
                .HasForeignKey(a => a.NIK)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Approval>()
                .HasOne(d => d.Department)
                .WithMany(a => a.Approvals)
                .HasForeignKey(d => d.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
