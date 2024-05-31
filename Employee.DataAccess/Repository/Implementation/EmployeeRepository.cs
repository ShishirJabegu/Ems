using Employee.DataAccess.Data;
using Employee.Model.Models;
using Employee.DataAccess.Repository.Interface;

namespace Employee.DataAccess.Repository.Implementation
{
    public class EmployeeRepository : Repository<Model.Models.Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _EmployeeDb;
        public EmployeeRepository(ApplicationDbContext employeeDb) : base(employeeDb)
        {
            _EmployeeDb = employeeDb;
        }

        public void Save()
        {
            _EmployeeDb.SaveChanges();
        }

        public void Update(Model.Models.Employee employee)
        {
            _EmployeeDb.Update(employee);
        }
    }
}
