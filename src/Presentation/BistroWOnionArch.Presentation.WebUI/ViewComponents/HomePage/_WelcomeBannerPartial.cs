using BistroWOnionArch.Core.Application.Services.WelcomeBannerServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _WelcomeBannerPartial :ViewComponent
    {
        private readonly IWelcomeBannerService _welcomeBannerService;

        public _WelcomeBannerPartial(IWelcomeBannerService welcomeBannerService)
        {
            _welcomeBannerService = welcomeBannerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _welcomeBannerService.TGetAll();
            return View(values);
        }
    }
}
