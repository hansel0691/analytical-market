using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blank.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Private
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        #endregion

        #region Constructor

        public Repository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }

        #endregion

        #region Methods


        #endregion

        public DbSet<T> DBSet => this._dbSet;

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _dbSet.Where(predicate);
            foreach (var entity in entities)
                _dbSet.Remove(entity);
        }

        public virtual async Task<bool> SaveAsync()
        {
            int modified = await _context.SaveChangesAsync();
            return modified > 0;
        }

        public virtual async Task<T> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<IList<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<IList<T>> GetMany(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<IList<T>> GetManyWithIncludes(Expression<Func<T, bool>> predicate, params string[] associations)
        {
            var query = _dbSet.AsQueryable();
            foreach (var assoc in associations)
                query = query.Include(assoc);

            return await query.Where(predicate).ToListAsync();
        }

        public virtual async Task<T> GetWithIncludes(Expression<Func<T, bool>> predicate, params string[] associations)
        {
            var query = _dbSet.AsQueryable();
            foreach (var assoc in associations)
                query = query.Include(assoc);

            return await query.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<bool> HasAny(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

    }
}
