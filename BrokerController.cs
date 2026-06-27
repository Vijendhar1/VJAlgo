
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/broker")]
public class BrokerController:ControllerBase
{
 [HttpGet("status")]
 public IActionResult Status()=>Ok(new{
   Broker="Zerodha",
   Connected=true,
   LastHeartbeat=DateTime.Now
 });

 [HttpPost("reconnect")]
 public IActionResult Reconnect()=>Ok(new{
   Success=true,
   Message="Reconnect initiated"
 });
}
