
namespace VJAlgo.Api.Models;
public class TradeDto{
 public string Symbol{get;set;}="";
 public string Option{get;set;}="";
 public decimal Entry{get;set;}
 public decimal Current{get;set;}
 public decimal StopLoss{get;set;}
 public decimal TrailStop{get;set;}
 public decimal Pnl{get;set;}
 public string Status{get;set;}="";
}
