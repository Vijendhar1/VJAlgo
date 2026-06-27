
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/performance")]
public class PerformanceController:ControllerBase
{
    [HttpGet("monthly")]
    public IActionResult Monthly()=>Ok(new[]{
        new{Month="Jan",PnL=124500},
        new{Month="Feb",PnL=98420},
        new{Month="Mar",PnL=152330},
        new{Month="Apr",PnL=118250},
        new{Month="May",PnL=174900},
        new{Month="Jun",PnL=132440}
    });
}
