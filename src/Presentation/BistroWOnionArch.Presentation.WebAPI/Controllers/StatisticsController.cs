using BistroWOnionArch.Core.Application.Dtos.Statistic.Requests;
using BistroWOnionArch.Core.Application.Services.StatisticServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BistroWOnionArch.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticsController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistic()
        {
            var values = await _statisticService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStatistic(CreateStatisticRequest createStatisticRequest)
        {
            await _statisticService.TInsert(createStatisticRequest);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStatistic(UpdateStatisticRequest updateStatisticRequest)
        {
            await _statisticService.TUpdate(updateStatisticRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStatistic(int id)
        {
            await _statisticService.TDelete(id);
            return Ok();
        }
    }
}
