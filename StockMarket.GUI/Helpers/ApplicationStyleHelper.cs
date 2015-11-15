using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.GUI.Assets;
using MahApps.Metro;

namespace StockMarket.GUI.Helpers
{
  class ApplicationStyleHelper
  {
    internal void ChangeStyle(MainWindow sender, ApplicationStyle applicationStyle)
    {
      switch (applicationStyle)
      {
        case ApplicationStyle.BlueLight:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Blue"), Theme.Light);
          break;
        case ApplicationStyle.BlueDark:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Blue"), Theme.Dark);
          break;
        case ApplicationStyle.GreenLight:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Green"), Theme.Light);
          break;
        case ApplicationStyle.GreenDark:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Green"), Theme.Dark);
          break;
        case ApplicationStyle.RedLight:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Red"), Theme.Light);
          break;
        case ApplicationStyle.RedDark:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Red"), Theme.Dark);
          break;
        case ApplicationStyle.PurpleLight:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Purple"), Theme.Light);
          break;
        case ApplicationStyle.PurpleDark:
          ThemeManager.ChangeTheme(sender, ThemeManager.DefaultAccents.First(a => a.Name == "Purple"), Theme.Dark);
          break;
      }
    }
  }
}
