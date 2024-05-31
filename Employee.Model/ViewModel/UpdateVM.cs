using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee.Model.ViewModel
{
    public class UpdateVM
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
        [DisplayName("Contact Number")]
        public long ContactNumber { get; set; }
    }
}
