using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class ReviewDTO
    {
        public int ReviewId { get; set; }
        public string Summary { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public ClubDTO Club { get; set; }
        public TrainerDTO Trainer { get; set; }
    }
}
