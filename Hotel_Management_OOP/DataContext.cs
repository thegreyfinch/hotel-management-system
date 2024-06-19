using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_OOP
{
    public class DataContext : DbContext
    {
        // create table
        public DbSet<Guest> Guests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = HotelManagement.db"); // connection string
        }
    }
}
