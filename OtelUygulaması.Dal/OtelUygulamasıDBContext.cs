using Microsoft.EntityFrameworkCore;
using OtelUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Dal
{
    public class OtelUygulamasıDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JI3UVS4;Database=Onl7OtelUygulamasıDb;Uid=sa;Pwd=123");

            //  optionsBuilder.UseSqlServer(@"Server=DESKTOP - VU62QDF\SQLSERVERMS;Database=Onl7OtelUygulamasıDb;Uid=sa;Pwd=123");

            //   optionsBuilder.UseSqlServer(@"ServerDESKTOP - G2S16HQ=;Database=Onl7OtelUygulamasıDb;Uid=sa;Pwd=123");


          



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityTypeConfiguration.EmployeeTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
