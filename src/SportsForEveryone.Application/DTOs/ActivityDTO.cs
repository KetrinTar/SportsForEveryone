using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class ActivityDTO
    {
        public int ActivityId { get; set; }
        public ActivityTypeDTO ActivityType { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Equipment { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        //public List<Schedule> Shedule { get; set; }
        public TrainerDTO Trainer { get; set; }
    }
}
