
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new[]{
        new{Id=1,Title="Trade Closed",Message="NIFTY CE target achieved",Time=DateTime.Now},
        new{Id=2,Title="Scanner",Message="SBIN added to watchlist",Time=DateTime.Now}
    });
}
