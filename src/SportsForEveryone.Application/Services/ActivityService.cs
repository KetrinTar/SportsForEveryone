using AutoMapper;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork<Activity> _unitOfWork;
        private readonly IMapper _mapper;

        public ActivityService(IUnitOfWork<Activity> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(ActivityCreationDTO activityCreation)
        {
            var activities = _mapper.Map<Activity>(activityCreation);
            _unitOfWork.EntityRepository.Add(activities);
            _unitOfWork.Save();
        }

        public List<ActivityDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<ActivityDTO>();
            foreach (var activity in list)
            {
                dto.Add(_mapper.Map<ActivityDTO>(activity));
                //dto.Add(new ActivityDTO
                //{
                //    ActivityId = activity.ActivityId,
                //    Name = activity.Name,
                //    Price = activity.Price,
                //    ActivityType = new ActivityTypeDTO { 
                //        ActivityTypeId = activity.ActivityType.ActivityTypeId,
                //        Name = activity.ActivityType.Name
                //    },
                //    Equipment = activity.Equipment,
                //    MinAge = activity.MinAge,
                //    MaxAge = activity.MaxAge,
                //    Trainer = new TrainerDTO { 
                //        TrainerId = activity.Trainer.TrainerId,
                //        Name = activity.Trainer.Name
                //    }
                //});
            }
            return dto;
        }
    }
}
