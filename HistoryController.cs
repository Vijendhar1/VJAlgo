
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/history")]
public class HistoryController:ControllerBase{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{
  new{Time="09:20",Symbol="NIFTY25000CE",Entry=120.5m,Exit=126.2m,Pnl=2850m}
 });
}
