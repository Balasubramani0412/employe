using System.ComponentModel.DataAnnotations;

namespace employe_project.Models.Entity
{
    public class Employees
    {
        [Key]
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set;}
        [Required]
        public string Country { get; set;}
        [Required]
        public string State { get; set;}
        [Required]
        public string City { get; set;}
        [Required]
        public string Pincode { get; set;}

    }
}
