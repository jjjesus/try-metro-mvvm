using System;

namespace StockMarket.Shared
{
  public class PriceUpdateEventArgs : EventArgs
  {
    public FxRate LatestPrice { get; set; }
  }
}
