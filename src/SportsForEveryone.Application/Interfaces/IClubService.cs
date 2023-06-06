using SportsForEveryone.Core.Entities;
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
        void CreateClub(Club club);
        List<Club> GetAll(Expression<Func<Club, bool>> filter = null, string props = "");
    }
}
