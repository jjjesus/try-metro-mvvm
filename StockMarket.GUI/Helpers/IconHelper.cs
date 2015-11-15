using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace StockMarket.GUI.Helpers
{
  class IconHelper
  {
    public static BitmapImage GetCcyIcon(string isocode) 
    {
      string uri;
      BitmapImage image;
      try
      {
        uri = string.Format("../Assets/Images/{0}.png", isocode);
        image = new BitmapImage(new Uri(uri, UriKind.Relative));
      }
      catch
      {
        uri = string.Format("../Assets/Images/{0}.png", "UNK");
        image = new BitmapImage(new Uri(uri, UriKind.Relative));
      }

      return image;
    }
  }
}
