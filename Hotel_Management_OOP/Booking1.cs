using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_OOP
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public DateOnly BookingDate { get; set; }
        public TimeOnly ArrivalTime { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public string? BookingStatus { get; set; }
        public int BookingExtension { get; set; }
        public int NoOfRooms { get; set; }

    }
}