using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Shared.ViewModels
{
    public class StockViewModel
    {
        public int StockId { get; set; }
        public string Symbol { get; set; }
        public string Market { get; set; }
        public int IndustryId { get; set; }
    }
}
