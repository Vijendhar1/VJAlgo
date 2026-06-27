
using Microsoft.AspNetCore.Mvc;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/callback")]
public class CallbackController:ControllerBase
{
    [HttpPost("broker")]
    public IActionResult Broker([FromBody] object payload)
    {
        return Ok(new{
            Success=true,
            ReceivedAt=DateTime.UtcNow,
            Message="Callback received"
        });
    }
}
