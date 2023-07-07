using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public ActivityType Type { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Equipment { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        //public List<Schedule> Shedule { get; set; }
        [ForeignKey("Trainers")]
        public Trainer Trainer { get; set; }
    }
}
