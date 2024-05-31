using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq.Expressions;

namespace Employee.DataAccess.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        List<T> GetAll();

        void Remove(T entity);
        T Get(Expression<Func<T, bool>> filter);
        public T FindById(int id);

    }
}
