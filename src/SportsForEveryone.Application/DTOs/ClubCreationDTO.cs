using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class ClubCreationDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public IFormFile Picture { get; set; }
        public List<int> Rate { get; set; }
        public virtual ICollection<TrainerDTO> Trainers { get; set; }
        public List<ActivityDTO> Activities { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }
        public ICollection<PostDTO> Posts { get; set; }
        public AdministratorDTO Administrators { get; set; }
    }
}
