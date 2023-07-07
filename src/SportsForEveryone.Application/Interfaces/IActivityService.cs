﻿using SportsForEveryone.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Interfaces
{
    public interface IActivityService
    {
        void Create(ActivityCreationDTO activityCreation);
        List<ActivityDTO> GetAll();
    }
}
