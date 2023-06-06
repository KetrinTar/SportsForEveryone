using SportsForEveryone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Interfaces
{
    public interface IActivityTypeService
    {
        void Create(ActivityType activityType);
        List<ActivityType> GetAll();
    }
}
