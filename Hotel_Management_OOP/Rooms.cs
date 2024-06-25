using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_OOP
{
     public class RoomsContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source = HMS.db"); //connection string and to use sqlite

        
    }

    public class Room
    {
        public int RoomId { get; set; }
    }

    public class RoomType
    {
        public string? Type;

        public int RoomTypes { get; internal set; }
    }
}
