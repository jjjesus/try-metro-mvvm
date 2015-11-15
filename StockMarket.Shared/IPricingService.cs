using System;
using System.Collections.Generic;

namespace StockMarket.Shared
{
  public interface IPricingService
  {
    List<FxRate> GetFullCurrentPrices();
    bool IsRunning { get; }
    void Start();
    void Stop();
    event EventHandler<PriceUpdateEventArgs> PriceUpdate;
  }
}
