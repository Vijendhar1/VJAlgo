
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/trades")]
public class TradesController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[]{
            new{
                Symbol="NIFTY 25000 CE",
                Side="BUY",
                Entry=120.50,
                Ltp=124.80,
                Pnl=2150
            }
        });
    }
}
