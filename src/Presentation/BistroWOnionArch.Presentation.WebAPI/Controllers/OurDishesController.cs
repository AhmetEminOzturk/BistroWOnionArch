using BistroWOnionArch.Core.Application.Dtos.OurDish.Requests;
using BistroWOnionArch.Core.Application.Services.OurDishServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurDishesController : ControllerBase
    {
        private readonly IOurDishService _ourDishService;

        public OurDishesController(IOurDishService ourDishService)
        {
            _ourDishService = ourDishService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOurDish()
        {
            var values = await _ourDishService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOurDish(CreateOurDishRequest createOurDishRequest)
        {
            await _ourDishService.TInsert(createOurDishRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOurDish(UpdateOurDishRequest updateOurDishRequest)
        {
            await _ourDishService.TUpdate(updateOurDishRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOurDish(int id)
        {
            await _ourDishService.TDelete(id);
            return Ok();
        }
    }
}
