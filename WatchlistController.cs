
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/watchlist")]
public class WatchlistController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new[]{
        new{Symbol="RELIANCE",Score=98.2,Price=1523.45},
        new{Symbol="SBIN",Score=95.4,Price=824.20},
        new{Symbol="ICICIBANK",Score=93.8,Price=1478.15}
    });
}
