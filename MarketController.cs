
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/market")]
public class MarketController:ControllerBase
{
 [HttpGet("indices")]
 public IActionResult Indices()=>Ok(new{
   Nifty=25124.55,
   BankNifty=56210.15,
   Sensex=82440.75,
   IndiaVix=12.48
 });
}
