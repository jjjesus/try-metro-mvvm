using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StockMarket.GUI.ViewModels;
using StockMarket.Service;
using StockMarket.Shared;

namespace StockMarket.GUI.Views
{
  /// <summary>
  /// Interaction logic for FxRatesWindow.xaml
  /// </summary>
  public partial class FxRatesWindow : UserControl
  {
    private FxRatesWindowViewModel vm;
    
    public FxRatesWindow()
    {
      InitializeComponent();

      IPricingService service = new PricingService();
      vm = new FxRatesWindowViewModel(service);
      this.DataContext = vm;
    }
  }
}
