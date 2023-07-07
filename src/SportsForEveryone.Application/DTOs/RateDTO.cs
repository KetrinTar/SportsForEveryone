using SportsForEveryone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class RateDTO
    {
        public int RateId { get; set; }
        public virtual Club Club { get; set; }
        public virtual Trainer Trainer { get; set; }
        public int RateValue { get; set; }
    }
}
