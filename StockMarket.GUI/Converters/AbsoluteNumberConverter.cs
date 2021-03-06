﻿using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using StockMarket.GUI.Helpers;

namespace StockMarket.GUI.Converters
{
  public class AbsoluteNumberConverter : IValueConverter
  {
    #region IValueConverter Members

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      return Math.Abs((decimal) value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
