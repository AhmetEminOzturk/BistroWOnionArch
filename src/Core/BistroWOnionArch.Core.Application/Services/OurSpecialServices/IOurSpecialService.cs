
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.OurSpecialServices
{
    public interface IOurSpecialService
    {
        Task<List<DisplayOurSpecialResponse>> TGetAll();
    }
}
