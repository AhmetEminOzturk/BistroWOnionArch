using BistroWOnionArch.Core.Application.Dtos.Dish.Requests;
using BistroWOnionArch.Core.Application.Services.DishServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishesController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDish()
        {
            var values = await _dishService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDish(CreateDishRequest createDishRequest)
        {
            await _dishService.TInsert(createDishRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDish(UpdateDishRequest updateDishRequest)
        {
            await _dishService.TUpdate(updateDishRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDish(int id)
        {
            await _dishService.TDelete(id);
            return Ok();
        }
    }
}
