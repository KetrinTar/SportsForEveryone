using SportsForEveryone.Core.Entities;

namespace SportsForEveryone.Infrastructure.Interfaces
{
    public interface IUnitOfWork<TEntity> where TEntity : class
    {
        IGenericRepository<TEntity> EntityRepository { get; }
        void Save();
    }
}