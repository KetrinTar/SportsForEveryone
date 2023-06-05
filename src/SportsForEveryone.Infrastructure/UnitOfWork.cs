using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Infrastructure
{
    public class UnitOfWork
    {
        private DataDbContext _context;
        private GenericRepository<Activity> _activityRepository;
        private GenericRepository<ActivityType> _activityTypeRepository;
        private GenericRepository<Administrator> _administratorRepository;
        private GenericRepository<Club> _clubRepository;
        private GenericRepository<Post> _postRepository;
        private GenericRepository<Review> _reviewRepository;
        private GenericRepository<Trainer> _trainerRepository;

        public GenericRepository<Activity> ActivityRepository
        {
            get
            {
                if(_activityRepository == null)
                {
                    _activityRepository = new GenericRepository<Activity>(_context);
                };
                return _activityRepository;
            }
        }

        public GenericRepository<ActivityType> ActivityTypeRepository
        {
            get
            {
                if(_activityTypeRepository == null)
                {
                    _activityTypeRepository = new GenericRepository<ActivityType>(_context);
                }
                return _activityTypeRepository;
            }
        }

        public GenericRepository<Administrator> AdministratorRepository
        {
            get
            {
                if(_administratorRepository == null)
                {
                    _administratorRepository = new GenericRepository<Administrator>(_context);
                }
                return _administratorRepository;
            }
        }

        public GenericRepository<Club> ClubRepository
        {
            get
            {
                if(_clubRepository == null)
                {
                    _clubRepository = new GenericRepository<Club>(_context);
                }
                return _clubRepository;
            }
        }

        public GenericRepository<Post> PostRepository
        {
            get
            {
                if(_postRepository == null)
                {
                    _postRepository = new GenericRepository<Post>(_context);
                }
                return _postRepository;
            }
        }

        public GenericRepository<Review> ReviewRepository
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

        public GenericRepository<Trainer> TrainerRepository
        {
            get
            {
                if(_trainerRepository == null)
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
            if(!disposed)
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
