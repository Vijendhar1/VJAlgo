
using Microsoft.Data.Sqlite;
namespace VJAlgo.Api.Repositories;
public class ScannerRepository
{
    private readonly string _db;
    public ScannerRepository(IConfiguration cfg){_db=cfg["DatabaseSettings:ScannerDatabase"]??"";}
    public IEnumerable<object> GetWatchlist(){
        using var con=new SqliteConnection($"Data Source={_db}");
        con.Open();
        var cmd=con.CreateCommand();
        cmd.CommandText="SELECT symbol,score,ltp,volume_ratio FROM priority_watchlist ORDER BY score DESC LIMIT 50";
        using var r=cmd.ExecuteReader();
        while(r.Read()){
            yield return new{
                Symbol=r["symbol"].ToString(),
                Score=Convert.ToDecimal(r["score"]),
                Ltp=Convert.ToDecimal(r["ltp"]),
                VolumeRatio=Convert.ToDecimal(r["volume_ratio"])
            };
        }
    }
}
