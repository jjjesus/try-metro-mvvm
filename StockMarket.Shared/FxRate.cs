using System;

namespace StockMarket.Shared
{
  public class FxRate : IFxRate
  {
    private FxRate(Ccy ccy, decimal bid, decimal offer, DateTime timestamp) 
    {
      this.Ccy = ccy;
      this.Bid = bid;
      this.PreviousOffer = offer;
      this.Offer = offer;
      this.Timestamp = timestamp;
    }

    public static FxRate Create(Ccy ccy, decimal bid, decimal offer, DateTime timestamp)
    {
      return new FxRate(ccy, bid, offer, timestamp);
    }

    public void UpdatePrice(decimal bid, decimal offer, DateTime timestamp)
    {
      this.Bid = bid;
      this.PreviousOffer = this.Offer;
      this.Offer = offer;
      this.Timestamp = timestamp;
    }

    public decimal Bid { get; private set; }
    public Ccy Ccy { get; private set; }
    public decimal Offer { get; private set; }
    public decimal PreviousOffer { get; private set; }
    public DateTime Timestamp { get; private set; }
  }
}