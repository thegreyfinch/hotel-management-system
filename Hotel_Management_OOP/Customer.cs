using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_OOP
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        //public int Age { get; set; } // not stored in db = derived attribute
        public string? Address { get; set; }
        public string? Religion { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        
       

    }
}