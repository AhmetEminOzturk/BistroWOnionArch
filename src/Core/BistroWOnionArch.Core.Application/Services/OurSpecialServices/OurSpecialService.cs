using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Requests;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Domain.Entities;
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

        public async Task TDelete(int id)
        {
            await _ourSpecialRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayOurSpecialResponse>> TGetAll()
        {
            var values = await _ourSpecialRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayOurSpecialResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateOurSpecialRequest createOurSpecialRequest)
        {
            var value = _mapper.Map<OurSpecial>(createOurSpecialRequest);
            await _ourSpecialRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateOurSpecialRequest updateOurSpecialRequest)
        {
            var value = _mapper.Map<OurSpecial>(updateOurSpecialRequest);
            await _ourSpecialRepository.UpdateAsync(value);
        }
    }
}
