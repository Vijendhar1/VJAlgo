
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/settings")]
public class SettingsController:ControllerBase{
 [HttpGet]
 public IActionResult Get()=>Ok(new{
   Broker="Zerodha",
   LiveTrading=false,
   TelegramAlerts=true,
   EmailAlerts=false
 });
}
