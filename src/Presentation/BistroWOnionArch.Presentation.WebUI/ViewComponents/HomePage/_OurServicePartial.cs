using BistroWOnionArch.Core.Application.Services.OurServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _OurServicePartial : ViewComponent
    {
        private readonly IOurServiceService _ourServiceService;

        public _OurServicePartial(IOurServiceService ourServiceService)
        {
            _ourServiceService = ourServiceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ourServiceService.TGetAll();
            return View(values);
        }
    }
}
