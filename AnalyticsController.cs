
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/analytics")]
public class AnalyticsController:ControllerBase
{
 [HttpGet("summary")]
 public IActionResult Summary()=>Ok(new{
   AvgWinner=2450.25,
   AvgLoser=820.10,
   ProfitFactor=2.98,
   MaxDrawdown=12450.00,
   SharpeRatio=1.82
 });
}
