
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/admin")]
public class AdminController:ControllerBase
{
 [HttpGet("users")]
 public IActionResult Users()=>Ok(new[]{
  new{Id=1,Name="Admin",Role="Administrator",Status="Active"},
  new{Id=2,Name="Trader",Role="User",Status="Active"}
 });
}
