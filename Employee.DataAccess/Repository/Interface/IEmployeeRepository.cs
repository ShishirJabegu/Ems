

namespace Employee.DataAccess.Repository.Interface
{
    public interface IEmployeeRepository : IRepository<Model.Models.Employee>
    {
        void Save();
        void Update(Model.Models.Employee employee);
    }
}
