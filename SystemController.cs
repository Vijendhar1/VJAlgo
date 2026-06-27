
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/system")]
public class SystemController:ControllerBase
{
    [HttpGet("health")]
    public IActionResult Health()=>Ok(new{
        TradingEngine="ONLINE",
        Scanner="ONLINE",
        Database="CONNECTED",
        SignalR="CONNECTED",
        Time=DateTime.Now
    });
}
