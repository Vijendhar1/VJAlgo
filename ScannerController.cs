
using Microsoft.AspNetCore.Mvc;

namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/scanner")]
public class ScannerController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[]{
            new { Symbol="RELIANCE", Score=98, Ltp=1523.20 },
            new { Symbol="SBIN", Score=95, Ltp=824.55 }
        });
    }
}
