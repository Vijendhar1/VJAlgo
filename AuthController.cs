
using Microsoft.AspNetCore.Mvc;
using VJAlgo.Api.Models;
namespace VJAlgo.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController:ControllerBase{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request){
        if(request.UserName=="admin" && request.Password=="admin123"){
            return Ok(new LoginResponse{
                UserName=request.UserName,
                Token=Guid.NewGuid().ToString(),
                Expiry=DateTime.UtcNow.AddHours(12)
            });
        }
        return Unauthorized();
    }
}
