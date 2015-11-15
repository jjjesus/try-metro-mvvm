using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using StockMarket.GUI.Assets;
using StockMarket.GUI.Helpers;
using StockMarket.GUI.Messages;
using StockMarket.GUI.ViewModels;

namespace StockMarket.GUI
{
  public partial class MainWindow
  {
    public MainWindow()
    {
      DataContext = new MainWindowViewModel(Dispatcher);
      InitializeComponent();

      // setup notifications
      Messenger.Default.Register<ApplicationStyleChangeMessage>(
        this, message => ChangeTheme(message.ApplicationStyle));
    }
        
    private void ChangeTheme(ApplicationStyle applicationStyle)
    {
      new ApplicationStyleHelper().ChangeStyle(this, applicationStyle);
    }
  }
}
