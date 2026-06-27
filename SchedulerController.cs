
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/scheduler")]
public class SchedulerController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new[]{
        new{Name="Stock Scanner",Status="Running",LastRun=DateTime.Now},
        new{Name="Option Scanner",Status="Running",LastRun=DateTime.Now},
        new{Name="Trade Sync",Status="Idle",LastRun=DateTime.Now}
    });
}
