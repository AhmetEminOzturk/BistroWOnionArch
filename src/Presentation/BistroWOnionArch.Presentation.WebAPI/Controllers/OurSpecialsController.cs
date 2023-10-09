using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Requests;
using BistroWOnionArch.Core.Application.Services.OurSpecialServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurSpecialsController : ControllerBase
    {
        private readonly IOurSpecialService _ourSpecialService;

        public OurSpecialsController(IOurSpecialService ourSpecialService)
        {
            _ourSpecialService = ourSpecialService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOurSpecial()
        {
            var values = await _ourSpecialService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOurSpecial(CreateOurSpecialRequest createOurSpecialRequest)
        {
            await _ourSpecialService.TInsert(createOurSpecialRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOurSpecial(UpdateOurSpecialRequest updateOurSpecialRequest)
        {
            await _ourSpecialService.TUpdate(updateOurSpecialRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOurSpecial(int id)
        {
            await _ourSpecialService.TDelete(id);
            return Ok();
        }
    }
}
