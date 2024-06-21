using System.ComponentModel.DataAnnotations;

namespace Hotel_Management_OOP
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}