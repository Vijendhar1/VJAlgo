
using Microsoft.AspNetCore.SignalR;
namespace VJAlgo.Api.Hubs;
public class TradingHub:Hub
{
    public async Task Ping()=>await Clients.Caller.SendAsync("pong",DateTime.UtcNow);
}
