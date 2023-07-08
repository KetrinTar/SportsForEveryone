using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class ClubDTO
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Picture { get; set; }
        public int Rate { get; set; }
        public virtual ICollection<TrainerDTO> Trainers { get; set; }
        public List<ActivityDTO> Activities { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }
        public ICollection<PostDTO> Posts { get; set; }
        public ICollection<AdministratorDTO> Administrators { get; set; }
    }
}
