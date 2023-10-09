using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurService.Requests;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.OurServiceServices
{
    public class OurServiceService : IOurServiceService
    {
        private readonly IOurServiceRepository _ourServiceRepository;
        private readonly IMapper _mapper;

        public OurServiceService(IOurServiceRepository ourServiceRepository, IMapper mapper)
        {
            _ourServiceRepository = ourServiceRepository;
            _mapper = mapper;
        }

        public async Task TDelete(int id)
        {
            await _ourServiceRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayOurServiceResponse>> TGetAll()
        {
            var values = await _ourServiceRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayOurServiceResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateOurServiceRequest createOurServiceRequest)
        {
            var value = _mapper.Map<OurService>(createOurServiceRequest);
            await _ourServiceRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateOurServiceRequest updateOurServiceRequest)
        {
            var value = _mapper.Map<OurService>(updateOurServiceRequest);
            await _ourServiceRepository.UpdateAsync(value);
        }
    }
}
