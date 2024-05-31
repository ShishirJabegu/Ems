using Employee.DataAccess.Data;
using Employee.DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Employee.DataAccess.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _employeeDb;
        DbSet<T> database;
        public Repository(ApplicationDbContext employeeDb) 
        {
            _employeeDb = employeeDb;
            this.database = employeeDb.Set<T>();
        }

        public void Add(T entity)
        {
            database.Add(entity);
        }

        public List<T> GetAll()
        {
            return database.ToList();
        }

        public T FindById(int id)
        {
            return database.Find(id);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = database;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _employeeDb.Remove(entity);
        }
    }
}
