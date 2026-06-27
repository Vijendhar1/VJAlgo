
namespace VJAlgo.Api.Repositories;
public class DashboardRepository
{
    public object GetSummary()=>new{
        TotalTrades=125,
        OpenTrades=4,
        ClosedTrades=121,
        RunningPnL=12540.55m,
        NetPnL=482340.20m,
        WinRate=81.5
    };
}
