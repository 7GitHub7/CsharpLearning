using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Entities
{
    public class RestaurantDBContext : DbContext
    {

        private string _connectionString = "Data Source = DESKTOP-2ERD1T2;Database = EF; Trusted_Connection = True;";
        public DbSet<Restaurant> Restaurants  { get; set; }
        public DbSet<Address>  Adress{ get; set; }
        public DbSet<Dish> Dish { get; set; }

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
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
