using AutoMapper;
using SportsForEveryone.Application.DTOs;
using SportsForEveryone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<ActivityType, ActivityTypeDTO>().ReverseMap();
            CreateMap<ActivityTypeCreationDTO, ActivityType>();

            CreateMap<Activity, ActivityDTO>().ReverseMap();
            CreateMap<ActivityCreationDTO, Activity>();

            CreateMap<Administrator, AdministratorDTO>().ReverseMap();
            CreateMap<AdministratorCreationDTO, Administrator>();

            CreateMap<Club, ClubDTO>().ReverseMap();
            CreateMap<ClubCreationDTO, Club>();

            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<PostCreationDTO, Post>();

            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<ReviewCreationDTO, Review>();

            CreateMap<Trainer, TrainerDTO>().ReverseMap();
            CreateMap<TrainerCreationDTO, Trainer>();
        }
    }
}
