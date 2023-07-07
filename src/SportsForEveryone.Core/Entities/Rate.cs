using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Rate
    {
        public int RateId { get; set; }
        [ForeignKey("Clubs")]
        public virtual Club Club { get; set; }
        [ForeignKey("Trainers")]
        public virtual Trainer Trainer { get; set; }
        public int RateValue { get; set; }
    }
}
