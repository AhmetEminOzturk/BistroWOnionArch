using BistroWOnionArch.Core.Application.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.TGetAll();
            return View(values);
        }
    }
}
