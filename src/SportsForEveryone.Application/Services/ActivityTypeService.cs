using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class ActivityTypeService : IActivityTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivityTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(ActivityType activityType)
        {;
            _unitOfWork.ActivityTypeRepository.Add(activityType);
            _unitOfWork.Save();
        }

        public List<ActivityType> GetAll()
        {
            return _unitOfWork.ActivityTypeRepository.GetAll().ToList();
        }
    }
}
