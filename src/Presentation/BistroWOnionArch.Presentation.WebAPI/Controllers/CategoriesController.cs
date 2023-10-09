using BistroWOnionArch.Core.Application.Dtos.Category.Requests;
using BistroWOnionArch.Core.Application.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            var values = await _categoryService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequest createCategoryRequest)
        {
            await _categoryService.TInsert(createCategoryRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            await _categoryService.TUpdate(updateCategoryRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.TDelete(id);
            return Ok();
        }
    }
}
