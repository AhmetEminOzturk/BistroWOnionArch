using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Responses;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Responses;
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

        public async Task<List<DisplayWelcomeBannerResponse>> TGetAll()
        {
            var values = await _welcomeBannerRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayWelcomeBannerResponse>>(values);
            return response;
        }
    }
}
