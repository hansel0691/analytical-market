using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Market { get; set; }
        public int IndustryId { get; set; }
    }
}
