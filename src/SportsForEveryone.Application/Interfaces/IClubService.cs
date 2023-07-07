using SportsForEveryone.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Interfaces
{
    public interface IClubService
    {
        void CreateClub(ClubCreationDTO clubCreation);
        List<ClubDTO> GetAll(Expression<Func<ClubDTO, bool>> filter = null, string props = "");
    }
}
