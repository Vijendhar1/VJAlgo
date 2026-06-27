
using Microsoft.Data.Sqlite;
namespace VJAlgo.Api.Repositories;
public class TradeRepository
{
    private readonly string _db;
    public TradeRepository(IConfiguration cfg)
    {
        _db = cfg["DatabaseSettings:TradesDatabase"] ?? "";
    }

    public IEnumerable<object> GetOpenTrades()
    {
        using var con = new SqliteConnection($"Data Source={_db}");
        con.Open();

        var cmd = con.CreateCommand();
        cmd.CommandText = "SELECT symbol, option_symbol, entry_premium, current_pnl FROM real_option_trades WHERE exit_time IS NULL";

        using var r = cmd.ExecuteReader();

        while(r.Read())
        {
            yield return new {
                Symbol=r["symbol"].ToString(),
                Option=r["option_symbol"].ToString(),
                Entry=Convert.ToDecimal(r["entry_premium"]),
                Pnl=Convert.ToDecimal(r["current_pnl"])
            };
        }
    }
}
