using BistroWOnionArch.Core.Application.Dtos.About.Responses;
using BistroWOnionArch.Core.Application.Dtos.About.Requests;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.AboutServices
{
    public interface IAboutService 
    {
        Task<List<DisplayAboutResponse>> TGetAll();
        Task TInsert(CreateAboutRequest createAboutRequest);
        Task TUpdate(UpdateAboutRequest updateAboutRequest);
        Task TDelete(int id);
    }
}
