using AutoMapper;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Core.Entities;
using SportsForEveryone.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork<Post> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly string container = "posts";

        public PostService(IUnitOfWork<Post> unitOfWork, IMapper mapper, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileService = fileService;
        }

        public async void Create(PostCreationDTO postCreation)
        {
            var posts = _mapper.Map<Post>(postCreation);
            if(postCreation.Picture != null)
            {
                posts.Picture = _fileService.SaveFile(container, postCreation.Picture);
            }
            _unitOfWork.EntityRepository.Add(posts);
            _unitOfWork.Save();
        }

        public List<PostDTO> GetAll()
        {
            var list = _unitOfWork.EntityRepository.GetAll();
            var dto = new List<PostDTO>();
            foreach (var post in list)
            {
                dto.Add(_mapper.Map<PostDTO>(post));
                //dto.Add(new PostDTO
                //{
                //    PostId = post.PostId,
                //    Picture = post.Picture,
                //    Summary = post.Summary,
                //    Club = new ClubDTO
                //    {
                //        ClubId = post.Club.ClubId,
                //        Name = post.Club.Name
                //    }
                //});
            }
            return dto;
        }
    }
}
