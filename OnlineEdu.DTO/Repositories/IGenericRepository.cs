using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace OnlineEdu.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> Table { get; }

        int Count();
        void Create(T entity);
        void Delete(int id);
        int FilteredCount(Expression<Func<T, bool>> predicate);
        T GetByFilter(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
        List<T> GetList();
        void Update(T entity);
    }
}