using BistroWOnionArch.Core.Application.Services.CategoryServices;
using BistroWOnionArch.Core.Application.Services.DishServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.Menu
{
    public class _DinnerPartial : ViewComponent
    {
        private readonly IDishService _dishService;
        private readonly ICategoryService _categoryService;

        public _DinnerPartial(IDishService dishService, ICategoryService categoryService)
        {
            _dishService = dishService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id=3)
        {
            var values = await _dishService.GetDishesByCategory(id);
            var category = await _categoryService.TGet(id);
            ViewBag.CategoryName = category.Name;
            return View(values);
        }
    }
}
