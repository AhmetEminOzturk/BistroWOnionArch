using BistroWOnionArch.Core.Application.Services.DishServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.Menu
{
    public class _DinnerPartial : ViewComponent
    {
        private readonly IDishService _dishService;

        public _DinnerPartial(IDishService dishService)
        {
            _dishService = dishService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dishService.GetDishesByCategory(3);
            return View(values);
        }
    }
}
