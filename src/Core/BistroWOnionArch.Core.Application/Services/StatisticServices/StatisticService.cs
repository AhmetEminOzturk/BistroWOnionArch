using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.StatisticRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.StatisticServices
{
    public class StatisticService : IStatisticService
    {
        private readonly IStatisticRepository _statisticRepository;
        private readonly IMapper _mapper;

        public StatisticService(IStatisticRepository statisticRepository, IMapper mapper)
        {
            _statisticRepository = statisticRepository;
            _mapper = mapper;
        }

        public async Task<List<DisplayStatisticResponse>> TGetAll()
        {
            var values = await _statisticRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayStatisticResponse>>(values);
            return response;
        }
    }
}
