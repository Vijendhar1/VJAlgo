
namespace VJAlgo.Api.Models;
public class LoginResponse{
    public string Token {get;set;}="";
    public string UserName {get;set;}="";
    public DateTime Expiry {get;set;}
}
