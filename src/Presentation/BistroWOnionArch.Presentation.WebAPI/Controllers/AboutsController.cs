using BistroWOnionArch.Core.Application.Dtos.About.Requests;
using BistroWOnionArch.Core.Application.Services.AboutServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAbout()
        {
            var values = await _aboutService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutRequest createAboutRequest)
        {
            await _aboutService.TInsert(createAboutRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutRequest updateAboutRequest)
        {
            await _aboutService.TUpdate(updateAboutRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.TDelete(id);
            return Ok();
        }
    }
}
