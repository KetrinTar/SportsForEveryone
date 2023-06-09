﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Core.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public string Summary { get; set; }
        public string Picture { get; set; }
        [ForeignKey("Clubs")]
        public virtual Club Club { get; set; }
    }
}
