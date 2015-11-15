﻿using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using StockMarket.GUI.Helpers;

namespace StockMarket.GUI.Converters
{
    public class CcyFromIconConverter : IValueConverter
    {
		#region IValueConverter Members

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
      return IconHelper.GetCcyIcon(value.ToString().Substring(0,3));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
