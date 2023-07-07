using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Infrastructure.Data
{
    public class UnitOfWork<TEntity> : IDisposable, IUnitOfWork<TEntity> where TEntity : class
    {
        private DataDbContext _context;

        private IGenericRepository<TEntity> _entityRepository;
 

        public UnitOfWork(DataDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<TEntity> EntityRepository
        {
            get
            {
                if (_entityRepository == null)
                {
                    _entityRepository = new GenericRepository<TEntity>(_context);
                };
                return _entityRepository;
            }
        }        
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
