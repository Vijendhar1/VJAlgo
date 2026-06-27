
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/risk")]
public class RiskController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()=>Ok(new{
        MaxRiskPerTrade=1000,
        MaxDailyLoss=5000,
        Exposure=245000,
        MarginUsed=182500,
        MarginAvailable=317500
    });
}
