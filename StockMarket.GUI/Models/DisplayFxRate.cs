using System;
using GalaSoft.MvvmLight;
using StockMarket.Shared;
using System.Windows.Media.Imaging;

namespace StockMarket.GUI.Models
{
	public class DisplayFxRate : ObservableObject, IFxRate
	{
		private DisplayFxRate() { }

		public static DisplayFxRate Create(FxRate rate)
		{
			var display = new DisplayFxRate()
				{
					Ccy = rate.Ccy,
					Bid = rate.Bid,
					Offer = rate.Offer,
					PreviousOffer = rate.PreviousOffer,
					Timestamp = rate.Timestamp,
					Spread = getSpread(rate),
          Delta = getDelta(rate)
				};

      return display;
		}

		public void Update(FxRate rate)
		{
			this.Bid = rate.Bid;
			this.Offer = rate.Offer;
			this.PreviousOffer = rate.PreviousOffer;
			this.Timestamp = rate.Timestamp;
			this.Spread = getSpread(rate);
			this.Delta = getDelta(rate);
		}

		private static decimal getSpread(IFxRate rate)
		{
			return Math.Round(rate.Offer - rate.Bid, 4);
		}

		private static decimal getDelta(IFxRate rate)
		{
			return Math.Round(rate.Offer - rate.PreviousOffer, 4);
		}

		public const string CcyPropertyName = "Ccy";
		private Ccy _ccy;
		public Ccy Ccy
		{
			get { return _ccy; }
      private set
			{
				if (_ccy == value) return;
				_ccy = value;
				RaisePropertyChanged(CcyPropertyName);
			}
		}

		public const string BidPropertyName = "Bid";
		private decimal _bid = 0;
		public decimal Bid
		{
			get { return _bid; }
      private set
			{
				if (_bid == value) return;
				_bid = value;
				RaisePropertyChanged(BidPropertyName);
			}
		}

		public const string OfferPropertyName = "Offer";
		private decimal _offer = 0;
		public decimal Offer
		{
			get { return _offer; }
      private set
			{
				if (_offer == value) return;
				_offer = value;
				RaisePropertyChanged(OfferPropertyName);
			}
		}

		public const string PreviousOfferPropertyName = "PreviousOffer";
		private decimal _previousOffer = 0;
		public decimal PreviousOffer
		{
			get { return _previousOffer; }
      private set
			{
				if (_previousOffer == value) return;
				_previousOffer = value;
				RaisePropertyChanged(PreviousOfferPropertyName);
			}
		}

		public const string DeltaPropertyName = "Delta";
		private decimal _delta = 0;
		public decimal Delta
		{
			get { return _delta; }
      private set
			{
				if (_delta == value) return;
				_delta = value;
				RaisePropertyChanged(DeltaPropertyName);
			}
		}

		public const string SpreadPropertyName = "Spread";
		private decimal _spread = 0;
		public decimal Spread
		{
			get { return _spread; }
      private set
			{
				if (_spread == value) return;
				_spread = value;
				RaisePropertyChanged(SpreadPropertyName);
			}
		}

		public const string TimestampPropertyName = "Timestamp";
		private DateTime _timestamp = DateTime.MinValue;
		public DateTime Timestamp
		{
			get { return _timestamp;}
      private set
			{
				if (_timestamp == value) return;
				_timestamp = value;
				RaisePropertyChanged(TimestampPropertyName);
			}
		}

    //private static string getDisplayCcy(Ccy ccy)
    //{
    //  string result;
    //  try
    //  {
    //    switch (ccy)
    //    {
    //      case Ccy.AUDtoUSD:
    //        result = "AUD to USD";
    //        break;

    //      case Ccy.EURtoCHF:
    //        result = "EUR to CHF";
    //        break;

    //      case Ccy.EURtoGBP:
    //        result = "EUR to GBP";
    //        break;

    //      case Ccy.EURtoJPY:
    //        result = "EUR to JPY";
    //        break;

    //      case Ccy.EURtoUSD:
    //        result = "EUR to USD";
    //        break;

    //      case Ccy.GBPtoJPY:
    //        result = "GBP to JPY";
    //        break;

    //      case Ccy.GBPtoUSD:
    //        result = "GBP to USD";
    //        break;

    //      case Ccy.USDtoCAD:
    //        result = "USD to CAD";
    //        break;

    //      case Ccy.USDtoCHF:
    //        result = "USD to CHF";
    //        break;

    //      case Ccy.USDtoJPY:
    //        result = "USD to JPY";
    //        break;

    //      default:
    //        result = "Unknown";
    //        break;
    //    }
    //  }
    //  catch
    //  {
    //    result = "Unknown";
    //  }

    //  return result;
    //}

    //private static BitmapImage getCcyIcon(string isocode)
    //{
    //  string uri;
    //  BitmapImage image;
    //  try
    //  {
    //    uri = string.Format("../Assets/Images/{0}.png", isocode);
    //    image = new BitmapImage(new Uri(uri, UriKind.Relative));
    //  }
    //  catch
    //  {
    //    uri = string.Format("../Assets/Images/{0}.png", "UNK");
    //    image = new BitmapImage(new Uri(uri, UriKind.Relative));
    //  }

    //  return image;
    //}
	}
}