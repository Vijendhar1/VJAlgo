
using Microsoft.AspNetCore.Mvc;

namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/export")]
public class ExportController:ControllerBase
{
    [HttpGet("trades")]
    public IActionResult Trades()
    {
        return Ok(new{
            FileName="Trades.csv",
            Status="Ready",
            Records=125
        });
    }
}
