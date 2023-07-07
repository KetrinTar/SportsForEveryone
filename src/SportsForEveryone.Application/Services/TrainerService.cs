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
    public class TrainerService : ITrainerService
    {
        private readonly IUnitOfWork<Trainer> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly string container = "trainers";

        public TrainerService(IUnitOfWork<Trainer> unitOfWork, IMapper mapper, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async void Create(TrainerCreationDTO trainerCreation)
        {
            var trainers = _mapper.Map<Trainer>(trainerCreation);
            if(trainerCreation.Picture != null)
            {
                trainers.Picture = await _fileService.SaveFile(container, trainerCreation.Picture);
            }
            _unitOfWork.EntityRepository.Add(trainers);
            _unitOfWork.Save();
        }

        public List<TrainerDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<TrainerDTO>();
            foreach (var trainer in list)
            {
                dto.Add(_mapper.Map<TrainerDTO>(trainer));
                //dto.Add(new TrainerDTO
                //{
                //    TrainerId = trainer.TrainerId,
                //    Name = trainer.Name,
                //    Activities = trainer.Activities.Select(act => new ActivityDTO
                //    {
                //        ActivityId = act.ActivityId,
                //        Name = act.Name
                //    }).ToList(),
                //    Link = trainer.Link,
                //    Picture = trainer.Picture,
                //    Club = new ClubDTO
                //    {
                //        ClubId = trainer.Club.ClubId,
                //        Name = trainer.Club.Name
                //    },
                //    Reviews = trainer.Reviews.Select(rew => new ReviewDTO
                //    {
                //        ReviewId = rew.ReviewId,
                //    }).ToList()
                //}) ;
            }
            return dto;
        }
    }
}
