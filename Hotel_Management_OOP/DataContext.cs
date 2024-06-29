using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_OOP
{
    public class UserDataContext : DbContext
    {
        
        // create table
        //public DbSet<Guest> Guests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = FloraSuitesLoginDB.db"); // connection string
        }

        public DbSet<User> Users { get; set; }

        // Settings db
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UserData.db");
        }
        //<type> , table
        public DbSet<User> Users { get; set; }
       */
    }



}
