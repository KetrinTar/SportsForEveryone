using SportsForEveryone.Core.Entities;

namespace SportsForEveryone.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Activity> ActivityRepository { get; }
        IGenericRepository<ActivityType> ActivityTypeRepository { get; }
        IGenericRepository<Administrator> AdministratorRepository { get; }
        IGenericRepository<Club> ClubRepository { get; }
        IGenericRepository<Post> PostRepository { get; }
        IGenericRepository<Review> ReviewRepository { get; }
        IGenericRepository<Trainer> TrainerRepository { get; }

        void Dispose();
        void Dispose(bool disposing);
        void Save();
    }
}