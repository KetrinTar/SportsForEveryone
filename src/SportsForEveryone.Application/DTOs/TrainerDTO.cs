using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class TrainerDTO
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public IFormFile Picture { get; set; }
        public virtual ClubDTO Club { get; set; }
        public virtual ICollection<ReviewDTO> Reviews { get; set; }
        public virtual ICollection<ActivityDTO> Activities { get; set; }
        public int Rate { get; set; }
    }
}
