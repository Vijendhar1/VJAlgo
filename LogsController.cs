
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/logs")]
public class LogsController:ControllerBase
{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{
  new{Time=DateTime.Now,Level="INFO",Message="Trading Engine Started"},
  new{Time=DateTime.Now,Level="INFO",Message="Scanner Connected"}
 });
}
