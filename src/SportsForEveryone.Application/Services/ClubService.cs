using AutoMapper;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class ClubService : IClubService
    {
        private readonly IUnitOfWork<Club> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly string container = "clubs";

        public ClubService(IUnitOfWork<Club> unitOfWork, IMapper mapper, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async void CreateClub(ClubCreationDTO clubCreation)
        {
            var clubs = _mapper.Map<Club>(clubCreation);
            if (clubCreation.Picture != null)
            {
                clubs.Picture = _fileService.SaveFile(container, clubCreation.Picture);
            }
            _unitOfWork.EntityRepository.Add(clubs);
            _unitOfWork.Save();
        }

        public List<ClubDTO> GetAll(Expression<Func<ClubDTO, bool>> filter = null, string props = "")
        {
            var filterEx = _mapper.Map<Expression<Func<Club, bool>>>(filter);
            var list = _unitOfWork.EntityRepository.GetAll(filterEx, props);
            var dto = new List<ClubDTO>();
            foreach (var club in list)
            {
                dto.Add(_mapper.Map<ClubDTO>(club));
            }
            return dto;
        }
       
    }
}
