using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Club
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Picture { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public List<Activity> Activities { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Administrator> Administrators { get; set; }
        //public virtual City City { get; set; }
    }
}
