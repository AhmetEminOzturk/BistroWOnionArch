using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Requests;
using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurDishRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.OurDishServices
{
    public class OurDishService : IOurDishService
    {
        private readonly IOurDishRepository _ourDishRepository;
        private readonly IMapper _mapper;

        public OurDishService(IOurDishRepository ourDishRepository, IMapper mapper)
        {
            _ourDishRepository = ourDishRepository;
            _mapper = mapper;
        }

        public async Task TDelete(int id)
        {
            await _ourDishRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayOurDishResponse>> TGetAll()
        {
            var values = await _ourDishRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayOurDishResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateOurDishRequest createOurDishRequest)
        {
            var value = _mapper.Map<OurDish>(createOurDishRequest);
            await _ourDishRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateOurDishRequest updateOurDishRequest)
        {
            var value = _mapper.Map<OurDish>(updateOurDishRequest);
            await _ourDishRepository.UpdateAsync(value);
        }
    }
}
