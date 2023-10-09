using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Requests;
using BistroWOnionArch.Core.Application.Services.AboutServices;
using BistroWOnionArch.Core.Application.Services.CategoryServices;
using BistroWOnionArch.Core.Application.Services.DishServices;
using BistroWOnionArch.Core.Application.Services.OurDishServices;
using BistroWOnionArch.Core.Application.Services.OurServiceServices;
using BistroWOnionArch.Core.Application.Services.OurSpecialServices;
using BistroWOnionArch.Core.Application.Services.StatisticServices;
using BistroWOnionArch.Core.Application.Services.WelcomeBannerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeBannersController : ControllerBase
    {
        private readonly IWelcomeBannerService _welcomeBannerService;
        
        public WelcomeBannersController(IWelcomeBannerService welcomeBannerService)
        {
            _welcomeBannerService = welcomeBannerService;          
        }

        [HttpGet]
        public async Task<IActionResult> GetWelcomeBanner()
        {
            var values = await _welcomeBannerService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWelcomeBanner(CreateWelcomeBannerRequest createWelcomeBannerRequest)
        {
            await _welcomeBannerService.TInsert(createWelcomeBannerRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWelcomeBanner(UpdateWelcomeBannerRequest updateWelcomeBannerRequest)
        {
            await _welcomeBannerService.TUpdate(updateWelcomeBannerRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWelcomeBanner(int id)
        {
            await _welcomeBannerService.TDelete(id);
            return Ok();
        }
    }
}
