using BistroWOnionArch.Core.Application.Services.OurSpecialServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _OurSpecialPartial : ViewComponent
    {
        private readonly IOurSpecialService _ourSpecialService;

        public _OurSpecialPartial(IOurSpecialService ourSpecialService)
        {
            _ourSpecialService = ourSpecialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ourSpecialService.TGetAll();
            return View(values);
        }
    }
}
