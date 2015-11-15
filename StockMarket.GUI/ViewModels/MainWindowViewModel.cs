using System.Windows.Threading;

namespace StockMarket.GUI.ViewModels
{
  public class MainWindowViewModel
  {
    private readonly Dispatcher _dispatcher;

    public MainWindowViewModel(Dispatcher dispatcher)
    {
      _dispatcher = dispatcher;
    }
  }
}