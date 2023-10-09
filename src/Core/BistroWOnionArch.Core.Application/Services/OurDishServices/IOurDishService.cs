
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Requests;
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
        Task TInsert(CreateOurDishRequest createOurDishRequest);
        Task TUpdate(UpdateOurDishRequest updateOurDishRequest);
        Task TDelete(int id);
    }
}
