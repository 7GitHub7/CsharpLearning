using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Entities
{
    public class RestaurantDBContext : DbContext
    {
        // connection string to database
        //private string _connectionString = "Data Source = DESKTOP-2ERD1T2;Database = EF; Trusted_Connection = True;";
        private string _connectionString = "Data Source = DESKTOP-DVUJDJ3;Database = EF; Trusted_Connection = True;";

        // set all tables based on classes
        public DbSet<Restaurant> Restaurants  { get; set; }
        public DbSet<Address>  Adress{ get; set; }
        public DbSet<Dish> Dish { get; set; }

        //add constraints
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Restaurant>()
                .Property(r=>r.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelbuilder.Entity<Dish>()
               .Property(r => r.Name)
               .IsRequired();
        }

        // use method UseSqlServer from Microsoft.EntityFrameworkCore.SqlServer to connect with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
