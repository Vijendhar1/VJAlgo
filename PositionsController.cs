
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/positions")]
public class PositionsController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new[]{
        new{Symbol="NIFTY25000CE",Qty=50,AvgPrice=125.5,MarketPrice=131.2,PnL=2850},
        new{Symbol="RELIANCE",Qty=100,AvgPrice=1518.2,MarketPrice=1524.8,PnL=660}
    });
}
