using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Infrastructure
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DataDbContext _context;
        private IGenericRepository<Activity> _activityRepository;
        private IGenericRepository<ActivityType> _activityTypeRepository;
        private IGenericRepository<Administrator> _administratorRepository;
        private IGenericRepository<Club> _clubRepository;
        private IGenericRepository<Post> _postRepository;
        private IGenericRepository<Review> _reviewRepository;
        private IGenericRepository<Trainer> _trainerRepository;

        public UnitOfWork(DataDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Activity> ActivityRepository
        {
            get
            {
                if (_activityRepository == null)
                {
                    _activityRepository = new GenericRepository<Activity>(_context);
                };
                return _activityRepository;
            }
        }

        public IGenericRepository<ActivityType> ActivityTypeRepository
        {
            get
            {
                if (_activityTypeRepository == null)
                {
                    _activityTypeRepository = new GenericRepository<ActivityType>(_context);
                }
                return _activityTypeRepository;
            }
        }

        public IGenericRepository<Administrator> AdministratorRepository
        {
            get
            {
                if (_administratorRepository == null)
                {
                    _administratorRepository = new GenericRepository<Administrator>(_context);
                }
                return _administratorRepository;
            }
        }

        public IGenericRepository<Club> ClubRepository
        {
            get
            {
                if (_clubRepository == null)
                {
                    _clubRepository = new GenericRepository<Club>(_context);
                }
                return _clubRepository;
            }
        }

        public IGenericRepository<Post> PostRepository
        {
            get
            {
                if (_postRepository == null)
                {
                    _postRepository = new GenericRepository<Post>(_context);
                }
                return _postRepository;
            }
        }

        public IGenericRepository<Review> ReviewRepository
        {
            get
            {
                if (_reviewRepository == null)
                {
                    _reviewRepository = new GenericRepository<Review>(_context);
                }
                return _reviewRepository;
            }
        }

        public IGenericRepository<Trainer> TrainerRepository
        {
            get
            {
                if (_trainerRepository == null)
                {
                    _trainerRepository = new GenericRepository<Trainer>(_context);
                }
                return _trainerRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
