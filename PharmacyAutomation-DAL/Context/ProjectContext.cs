using Microsoft.EntityFrameworkCore;
using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<BasketDetail> BasketDetails { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }

        public static string HashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IJ5TVSC;Database=PharmacyDB;User Id=sa;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account() { AccountId=1, IsAdmin=true, IsValid= true, Password = HashPassword("1234"), Mail= "John@hotmail.com"}
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee() {EmployeeId = 1, AccountId= 1, Adress= "Eczane", Gender = PharmacyAutomation_DATA.Enums.Gender.Male, Name="John Doe"}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
