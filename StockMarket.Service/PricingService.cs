﻿using System;
using System.Threading;
using System.Threading.Tasks;
using StockMarket.Shared;
using System.Collections.Generic;

namespace StockMarket.Service
{
  public class PricingService : IPricingService
  {
    PriceFactory factory;
    bool _isRunning = false;
    public bool IsRunning { get { return _isRunning; } }

    public PricingService()
    {
      factory = new PriceFactory();
    }

    public void Start()
    {
      Task.Factory.StartNew(() =>
      {
        _isRunning = true;
        while (_isRunning)
        {
          Thread.Sleep(10);
          if (PriceUpdate == null) continue;
          FxRate latestPrice = factory.GetNextPrice();
          PriceUpdate(null, new PriceUpdateEventArgs { LatestPrice = latestPrice });
        }
      });
    }

    public void Stop()
    {
      _isRunning = false;
    }

    public List<FxRate> GetFullCurrentPrices()
    {
      return factory.CurrentPrices;
    }

    public event EventHandler<PriceUpdateEventArgs> PriceUpdate;
  }
}