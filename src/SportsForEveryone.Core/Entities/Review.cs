using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    [Table("Reviews")]
    public class Review
    {
        public int ReviewId { get; set; }
        public string Summary { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public Club Club { get; set; }
        public Trainer Trainer { get; set; }
    }
}
