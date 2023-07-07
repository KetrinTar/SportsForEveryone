using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }
        [ForeignKey("Clubs")]
        public virtual Club Club { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
