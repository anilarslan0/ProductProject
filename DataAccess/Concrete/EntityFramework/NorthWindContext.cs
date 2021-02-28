using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje claslarını bağlamak
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //bu metot senin projen hangi Db ile ilişkili belirttiğin yer.override yazınca kendi veriyor.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }


        public DbSet<Product> Products { get; set; } //kendi sınıflarımla veri tabanlarında tabloları ilişkilendirdik.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }   
    
}
