
using Microsoft.AspNetCore.Mvc;

namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/reports")]
public class ReportsController:ControllerBase
{
    [HttpGet("daily")]
    public IActionResult Daily()
    {
        return Ok(new{
            TotalTrades=28,
            Winners=21,
            Losers=7,
            NetPnL=12450.75,
            Brokerage=842.30
        });
    }
}
