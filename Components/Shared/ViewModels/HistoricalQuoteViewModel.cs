using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Shared.ViewModels
{
    public class HistoricalQuoteViewModel
    {
        public int HistoricalQuoteId { get; set; }
        public int StockId { get; set; }
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double AdjustedClose { get; set; }
        public int Volume { get; set; }
    }
}
