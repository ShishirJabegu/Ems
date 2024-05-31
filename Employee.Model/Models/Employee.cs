using System.ComponentModel.DataAnnotations;

namespace Employee.Model.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Post { get; set; }
        [Required]
        public int Salary { get; set; }
        public string Address { get; set; }
        public long ContactNumber { get; set; }
    }
}
