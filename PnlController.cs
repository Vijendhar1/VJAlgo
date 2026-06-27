
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/pnl")]
public class PnlController:ControllerBase{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{
  new{Date="2026-06-22",NetPnL=12450},
  new{Date="2026-06-23",NetPnL=8420},
  new{Date="2026-06-24",NetPnL=-1520}
 });
}
