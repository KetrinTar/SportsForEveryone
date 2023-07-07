using AutoMapper;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork<Review> _unitOfWork;
        private readonly IMapper _mapper;

        public ReviewService(IUnitOfWork<Review> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(ReviewCreationDTO review)
        {
            var Reviews = _mapper.Map<Review>(review);
            _unitOfWork.EntityRepository.Add(Reviews);
            _unitOfWork.Save();
        }

        public List<ReviewDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<ReviewDTO>();
            foreach (var review in list)
            {
                dto.Add(_mapper.Map<ReviewDTO>(review));
                //dto.Add(new ReviewDTO
                //{
                //    ReviewId = review.ReviewId,
                //    Rate = review.Rate,
                //    Summary = review.Summary,
                //    Date = review.Date,
                //    Club = new ClubDTO
                //    {
                //        ClubId = review.Club.ClubId,
                //        Name = review.Club.Name
                //    },
                //    Trainer = new TrainerDTO
                //    {
                //        TrainerId = review.Trainer.TrainerId,
                //        Name = review.Trainer.Name
                //    }
                //});
            }
            return dto;
        }
    }
}
