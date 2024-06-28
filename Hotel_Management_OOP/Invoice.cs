using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_OOP
{
    public class Invoice
    {
        [Key]
        public int PaymentID { get; set; }
        public int GuestID { get; set; }
        public int PaymentAmount { get; set; } //double ba dapat
        public DateTime? PaymentDate { get; set; } 
        public string? PaymentMethod { get; set; }
        public int ExtPayment { get; set; }
        public string? PaymentStatus { get; set; }
    }
}