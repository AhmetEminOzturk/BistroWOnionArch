using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Requests;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Responses;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.WelcomeBannerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.WelcomeBannerServices
{
    public class WelcomeBannerService : IWelcomeBannerService
    {
        private readonly IWelcomeBannerRepository _welcomeBannerRepository;
        private readonly IMapper _mapper;

        public WelcomeBannerService(IWelcomeBannerRepository welcomeBannerRepository, IMapper mapper)
        {
            _welcomeBannerRepository = welcomeBannerRepository;
            _mapper = mapper;
        }

        public async Task TDelete(int id)
        {
            await _welcomeBannerRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayWelcomeBannerResponse>> TGetAll()
        {
            var values = await _welcomeBannerRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayWelcomeBannerResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateWelcomeBannerRequest createWelcomeBannerRequest)
        {
            var value = _mapper.Map<WelcomeBanner>(createWelcomeBannerRequest);
            await _welcomeBannerRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateWelcomeBannerRequest updateWelcomeBannerRequest)
        {
            var value = _mapper.Map<WelcomeBanner>(updateWelcomeBannerRequest);
            await _welcomeBannerRepository.UpdateAsync(value);
        }
    }
}
