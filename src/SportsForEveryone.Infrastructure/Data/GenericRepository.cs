using Microsoft.EntityFrameworkCore;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Infrastructure.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DataDbContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(DataDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, string props = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null) query = query.Where(filter).AsNoTracking();
            foreach (var prop in props.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(prop).AsNoTracking();
            }

            return query.ToList();
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
    }
}
