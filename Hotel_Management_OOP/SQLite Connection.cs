using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Syncfusion.Windows.Forms.TabBar;

namespace Hotel_Management_OOP
{

    public class HMSDataContext : DbContext
    {
        // create table
        //public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = HMS.db"); // connection string
        }
       
    }

    //internal class SQLite_Connection
   // {
       // var connection = new SqliteConnection("Data Source=databaseFile");
       // connection.Open();
    //}
    
}
