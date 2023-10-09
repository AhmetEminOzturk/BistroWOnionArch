using BistroWOnionArch.Core.Application.Services.OurDishServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _OurDishPartial : ViewComponent
    {
        private readonly IOurDishService _ourDishService;

        public _OurDishPartial(IOurDishService ourDishService)
        {
            _ourDishService = ourDishService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ourDishService.TGetAll();
            return View(values);
        }
    }
}
