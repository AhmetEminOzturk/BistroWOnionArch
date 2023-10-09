using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.About.Responses;
using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.About.Requests;

using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task TDelete(int id)
        {
            await _aboutRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayAboutResponse>> TGetAll()
        {
            var values = await _aboutRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayAboutResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateAboutRequest createAboutRequest)
        {
            var value = _mapper.Map<About>(createAboutRequest);
            await _aboutRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateAboutRequest updateAboutRequest)
        {
            var value = _mapper.Map<About>(updateAboutRequest);
            await _aboutRepository.UpdateAsync(value);
        }
    }
}
