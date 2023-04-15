using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class PersonelDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Permit> Permits { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Adress
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-UDLV6G6V;Initial Catalog=PwaDb;Integrated Security=true;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Employees
            modelBuilder.Entity<Employee>().Property(e => e.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Surname).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Gender).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.BirthDate).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.StartDate).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Email).HasColumnType("VARCHAR").HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Pass).HasColumnType("VARCHAR").HasMaxLength(8000).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Adress).HasColumnType("VARCHAR").HasMaxLength(500).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.PhoneNumber).HasColumnType("VARCHAR").HasMaxLength(14).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Title).HasColumnType("VARCHAR").HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Role).HasColumnType("VARCHAR").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique(true);

            //Department
            modelBuilder.Entity<Department>().Property(d => d.Name).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Department>().HasIndex(d => d.Name).IsUnique(true);

            //Activity
            modelBuilder.Entity<Activity>().Property(a => a.Title).HasColumnType("VARCHAR").HasMaxLength(400).IsRequired();
            modelBuilder.Entity<Activity>().Property(a => a.Contents).HasColumnType("VARCHAR").HasMaxLength(8000);
            modelBuilder.Entity<Activity>().Property(a => a.StartDate).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<Activity>().Property(a => a.EndDate).HasColumnType("DATE").IsRequired();

            //Notification
            modelBuilder.Entity<Notification>().Property(n => n.Title).HasColumnType("VARCHAR").HasMaxLength(400).IsRequired();
            modelBuilder.Entity<Notification>().Property(n => n.Contents).HasColumnType("VARCHAR").HasMaxLength(8000);
            modelBuilder.Entity<Notification>().Property(n => n.PublishDate).HasColumnType("DATE").IsRequired();

            //Permit
            modelBuilder.Entity<Permit>().Property(a => a.StartDate).HasColumnType("DATE").IsRequired();            
            modelBuilder.Entity<Permit>().Property(a => a.EndDate).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<Permit>().Property(a => a.Explanation).HasColumnType("VARCHAR").HasMaxLength(400).IsRequired();

            base.OnModelCreating(modelBuilder);
        }


    }
}
