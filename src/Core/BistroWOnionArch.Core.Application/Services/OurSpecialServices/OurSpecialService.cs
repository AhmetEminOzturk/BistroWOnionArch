using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurSpecialRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.OurSpecialServices
{
    public class OurSpecialService : IOurSpecialService
    {
        private readonly IOurSpecialRepository _ourSpecialRepository;
        private readonly IMapper _mapper;

        public OurSpecialService(IOurSpecialRepository ourSpecialRepository, IMapper mapper)
        {
            _ourSpecialRepository = ourSpecialRepository;
            _mapper = mapper;
        }

        public async Task<List<DisplayOurSpecialResponse>> TGetAll()
        {
            var values = await _ourSpecialRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayOurSpecialResponse>>(values);
            return response;
        }
    }
}
