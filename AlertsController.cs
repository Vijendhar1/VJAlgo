
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/alerts")]
public class AlertsController:ControllerBase
{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{
   new{Time=DateTime.Now,Type="ENTRY",Message="BUY NIFTY 25000 CE"},
   new{Time=DateTime.Now,Type="SL",Message="Trailing SL Updated"}
 });
}
