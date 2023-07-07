using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.DTOs
{
    public class AdministratorDTO
    {
        public int AdministratorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ClubId { get; set; }
        public virtual ClubDTO Club { get; set; }
    }
}
