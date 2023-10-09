
using BistroWOnionArch.Core.Application.Dtos.Statistic.Requests;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Requests;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.StatisticServices
{
    public interface IStatisticService  
    {
        Task<List<DisplayStatisticResponse>> TGetAll();
        Task TInsert(CreateStatisticRequest createStatisticRequest);
        Task TUpdate(UpdateStatisticRequest updateStatisticRequest);
        Task TDelete(int id);
    }
}
