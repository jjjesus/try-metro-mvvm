using System.Windows.Controls;
using StockMarket.GUI.ViewModels;

namespace StockMarket.GUI.Views
{
  /// <summary>
  /// Interaction logic for SettingsWindow.xaml
  /// </summary>
  public partial class SettingsWindow : UserControl
  {
    private SettingsWindowViewModel vm = new SettingsWindowViewModel();
    
    public SettingsWindow()
    {
      InitializeComponent();
      this.DataContext = vm;
    }
  }
}