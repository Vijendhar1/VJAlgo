
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/dashboard")]
public class DashboardController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new{
        TotalTrades=0,
        OpenTrades=0,
        ClosedTrades=0,
        RunningPnL=0,
        NetPnL=0
    });
}
