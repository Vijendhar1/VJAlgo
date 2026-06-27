
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/strategy")]
public class StrategyController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new[]{
        new{Name="Momentum",Trades=182,WinRate=84.2,NetPnL=124820},
        new{Name="Breakout",Trades=91,WinRate=80.1,NetPnL=74520},
        new{Name="Reversal",Trades=67,WinRate=72.4,NetPnL=28110}
    });
}
