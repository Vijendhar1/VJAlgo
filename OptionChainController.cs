
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;
[ApiController]
[Route("api/optionchain")]
public class OptionChainController:ControllerBase{
 [HttpGet]
 public IActionResult Get()=>Ok(new[]{
   new{Strike=25000,CallOI=520000,PutOI=610000,CallLtp=120.5,PutLtp=98.2},
   new{Strike=25100,CallOI=410000,PutOI=720000,CallLtp=84.1,PutLtp=132.4}
 });
}
