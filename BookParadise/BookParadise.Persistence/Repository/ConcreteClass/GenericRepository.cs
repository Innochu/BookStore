using BookParadise.Persistence.DBContextFolder;
using BookParadise.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Persistence.Repository.ConcreteClass
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BookParadiseDb _bookParadiseDb;
        internal DbSet<T> dbSet;
        public GenericRepository(BookParadiseDb bookParadiseDb)
        {
            _bookParadiseDb = bookParadiseDb;
            dbSet = _bookParadiseDb.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetById(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }
    }
}
