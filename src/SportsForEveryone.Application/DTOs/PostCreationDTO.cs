using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class PostCreationDTO
    {
        public string Summary { get; set; }
        public IFormFile Picture { get; set; }
        public virtual ClubDTO Club { get; set; }
    }
}
