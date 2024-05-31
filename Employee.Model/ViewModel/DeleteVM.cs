using System.ComponentModel;

namespace Employee.Model.ViewModel
{
    public class DeleteVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        [DisplayName("Contact Number")]
        public long ContactNumber { get; set; }
    }
}
