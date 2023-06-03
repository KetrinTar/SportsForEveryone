using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Schedule
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
