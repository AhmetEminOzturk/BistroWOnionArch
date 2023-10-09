using BistroWOnionArch.Core.Application.Services.StatisticServices;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebUI.ViewComponents.HomePage
{
    public class _StatisticPartial : ViewComponent
    {
        private readonly IStatisticService _statisticService;

        public _StatisticPartial(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _statisticService.TGetAll();
            return View(values);
        }
    }
}
