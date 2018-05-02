using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Shared.ViewModels
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Market { get; set; }
        public int IndustryId { get; set; }
    }
}
