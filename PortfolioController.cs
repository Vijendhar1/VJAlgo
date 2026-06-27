
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/portfolio")]
public class PortfolioController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new{
        Capital=1000000,
        Invested=742500,
        Available=257500,
        RunningPnL=18420.55,
        DayPnL=3250.20
    });
}
