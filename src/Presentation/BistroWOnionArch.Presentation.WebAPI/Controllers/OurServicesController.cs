using BistroWOnionArch.Core.Application.Dtos.OurService.Requests;
using BistroWOnionArch.Core.Application.Services.OurServiceServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurServicesController : ControllerBase
    {
        private readonly IOurServiceService _ourServiceService;

        public OurServicesController(IOurServiceService ourServiceService)
        {
            _ourServiceService = ourServiceService;
        }
        [HttpGet]
        public async Task<IActionResult> GetOurService()
        {
            var values = await _ourServiceService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOurService(CreateOurServiceRequest createOurServiceRequest)
        {
            await _ourServiceService.TInsert(createOurServiceRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOurService(UpdateOurServiceRequest updateOurServiceRequest)
        {
            await _ourServiceService.TUpdate(updateOurServiceRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOurService(int id)
        {
            await _ourServiceService.TDelete(id);
            return Ok();
        }
    }
}
