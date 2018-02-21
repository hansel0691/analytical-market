using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blank.Core.Repository
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> predicate);

        Task<bool> SaveAsync();

        Task<T> Get(int id);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<IList<T>> GetMany(Expression<Func<T, bool>> predicate);
        Task<T> GetWithIncludes(Expression<Func<T, bool>> predicate, params string[] associations);
        Task<IList<T>> GetManyWithIncludes(Expression<Func<T, bool>> predicate, params string[] associations);
        Task<IList<T>> GetAll();
        Task<bool> HasAny(Expression<Func<T, bool>> predicate);

        DbSet<T> DBSet { get; }
    }
}
