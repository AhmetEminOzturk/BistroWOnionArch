
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.OurDishServices
{
    public interface IOurDishService
    {
        Task<List<DisplayOurDishResponse>> TGetAll();
    }
}
