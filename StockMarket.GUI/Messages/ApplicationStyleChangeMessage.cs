using GalaSoft.MvvmLight.Messaging;
using StockMarket.GUI.Assets;

namespace StockMarket.GUI.Messages
{
  public class ApplicationStyleChangeMessage : MessageBase
  {
    public ApplicationStyle ApplicationStyle { get; set; }
  }
}
