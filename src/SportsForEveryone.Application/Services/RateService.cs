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
    public class RateService : IRateService
    {
        private readonly IUnitOfWork<Rate> _unitOfWork;
        private readonly IMapper _mapper;

        public RateService(IUnitOfWork<Rate> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(RateCreationDTO rate)
        {
            var rates = _mapper.Map<Rate>(rate);
            _unitOfWork.EntityRepository.Add(rates);
            _unitOfWork.Save();
        }

        public List<RateDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<RateDTO>();
            foreach (var rate in list)
            {
                dto.Add(_mapper.Map<RateDTO>(rate));
                //dto.Add(new RateDTO
                //{
                //    RateId = Rate.RateId,
                //    Rate = Rate.Rate,
                //    Summary = Rate.Summary,
                //    Date = Rate.Date,
                //    Club = new ClubDTO
                //    {
                //        ClubId = Rate.Club.ClubId,
                //        Name = Rate.Club.Name
                //    },
                //    Trainer = new TrainerDTO
                //    {
                //        TrainerId = Rate.Trainer.TrainerId,
                //        Name = Rate.Trainer.Name
                //    }
                //});
            }
            return dto;
        }
    }
}
