using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class ClubService : IClubService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClubService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateClub(Club club)
        {
            _unitOfWork.ClubRepository.Add(club);
            _unitOfWork.Save();
        }

        public List<Club> GetAll(Expression<Func<Club, bool>> filter = null, string props = "")
        {
            return _unitOfWork.ClubRepository.GetAll(filter, props).ToList();
        }
    }
}
