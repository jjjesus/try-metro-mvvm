using System;

namespace StockMarket.Shared
{
  public interface IFxRate
  {
    decimal Bid { get; }
    Ccy Ccy { get; }
    decimal Offer { get; }
    decimal PreviousOffer { get; }
    DateTime Timestamp { get; }
  }
}
