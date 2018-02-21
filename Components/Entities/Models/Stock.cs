using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Symbol { get; set; }
        public string Market { get; set; }
        public int IndustryId { get; set; }
    }
}
