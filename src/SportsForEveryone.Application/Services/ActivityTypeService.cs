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
    public class ActivityTypeService : IActivityTypeService
    {
        private readonly IUnitOfWork<ActivityType> _unitOfWork;
        private readonly IMapper _mapper;

        public ActivityTypeService(IUnitOfWork<ActivityType> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(ActivityTypeCreationDTO activityTypeCreation)
        {
            var activityTypes = _mapper.Map<ActivityType>(activityTypeCreation);
            _unitOfWork.EntityRepository.Add(activityTypes);
            _unitOfWork.Save();
        }

        public List<ActivityTypeDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<ActivityTypeDTO>();
            foreach (var activityType in list)
            {
                dto.Add(new ActivityTypeDTO
                {
                    ActivityTypeId = activityType.Id,
                    Name = activityType.Name,
                });
            }
            return dto;
        }
    }
}
