using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using StockMarket.GUI.Models;
using StockMarket.Shared;

namespace StockMarket.GUI.ViewModels
{
  public class FxRatesWindowViewModel : ViewModelBase
  {
    private IPricingService pricingService;
    
    public BindingList<DisplayFxRate> DisplayFxRates { get; set; }
    public ICommand ServiceRunningCommand { get; set; }
    public ICommand SubscriptionCommand { get; set; }
    
    public FxRatesWindowViewModel(IPricingService service)
    {
      pricingService = service;
      GetLatestPrices();

      SubscriptionCommand = new RelayCommand(SubscriptionCommand_Execute);
      ServiceRunningCommand = new RelayCommand(ServiceRunningCommand_Execute);

      var priceUpdates = Observable.FromEventPattern<PriceUpdateEventArgs>(
        pricingService, "PriceUpdate");

      priceUpdates.Where(e => (e.EventArgs.LatestPrice.Ccy == Ccy.EURtoGBP) 
                          && (Subscribed))
                  //.Throttle(TimeSpan.FromSeconds(1))
                  .Subscribe(PriceUpdate);
    }

    public void PriceUpdate(EventPattern<PriceUpdateEventArgs> e)
    {
        var displayRate = DisplayFxRates.Where(
          rate => rate.Ccy == e.EventArgs.LatestPrice.Ccy).First();
        
        if (displayRate != null)
          displayRate.Update(e.EventArgs.LatestPrice);
    }


    private void GetLatestPrices()
    {
      DisplayFxRates = new BindingList<DisplayFxRate>();
      var currentRates = pricingService.GetFullCurrentPrices();
      foreach (var latestRate in currentRates)
      {
        var displayRate = DisplayFxRate.Create(latestRate);
        DisplayFxRates.Add(displayRate);
      }
    }

    private const string SubscribedPropertyName = "Subscribed";
    private bool _subscribed = false;
    public bool Subscribed
    {
      get { return _subscribed; }
      set
      {
        if (_subscribed == value) return;
        _subscribed = value;
        RaisePropertyChanged(SubscribedPropertyName);
      }
    }

    private const string ServiceRunningPropertyName = "ServiceRunning";
    private bool _serviceRunning;
    public bool ServiceRunning
    {
      get 
      {
        return _serviceRunning;
      }
      set
      {
        if (_serviceRunning == value) return;
        _serviceRunning = value;
        RaisePropertyChanged(ServiceRunningPropertyName);
      }
    }

    void ServiceRunningCommand_Execute()
    {
      if (pricingService.IsRunning)
      {
        pricingService.Stop();
        ServiceRunning = false;
      }
      else
      {
        pricingService.Start();
        ServiceRunning = true;
      }
    }

    void SubscriptionCommand_Execute()
    {
      //toggle subscribed
      Subscribed = !Subscribed;
    }
  }
}
