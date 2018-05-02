using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Shared.ViewModels
{
    public class DividendViewModel
    {
        public int Id { get; set; }
        public DateTime ExDividendDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime DeclaredDate { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
    }
}
