using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Business.AlphaVantage
{
    public class AlphaQuoteModel
    {
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double adjustedclose { get; set; }
        public long volume { get; set; }
        public double dividendamount { get; set; }
        public double splitcoefficient { get; set; }
    }
}
