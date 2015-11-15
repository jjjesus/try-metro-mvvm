using System.ComponentModel;
using StockMarket.GUI.Assets;
using GalaSoft.MvvmLight.Messaging;
using StockMarket.GUI.Messages;
using GalaSoft.MvvmLight;

namespace StockMarket.GUI.ViewModels
{
  public class SettingsWindowViewModel : ViewModelBase
  {
    ApplicationStyle _selectedApplicationStyle;

    public SettingsWindowViewModel()
    {
      _selectedApplicationStyle = ApplicationStyle.BlueLight;
    }

    public ApplicationStyle SelectedApplicationStyle
    {
      get { return _selectedApplicationStyle; }
      set
      {
        _selectedApplicationStyle = value;
        RaisePropertyChanged("SelectedApplicationStyle");

        Messenger.Default.Send(new ApplicationStyleChangeMessage() { ApplicationStyle = _selectedApplicationStyle });
      }
    }
  }
}
