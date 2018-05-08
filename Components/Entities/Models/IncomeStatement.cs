using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities.Models
{
    public class IncomeStatement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Revenue { get; set; }
        public double CostOfRevenue { get; set; }
        public double GrossProfit { get; set; }
        public double Research_Development { get; set; }
        public double SellingGeneral_Administrative { get; set; }
        public double OperatingExpenses { get; set; }
        public double OperatingIncome { get; set; }
        public double EarningsBeforeTax { get; set; }
        public double EBIT { get; set; }
        public double EBITDA { get; set; }
        public double InterestExpense { get; set; }
        public double IncomeTaxExpense { get; set; }
        public double DiscontinuedOperations { get; set; }
        public double NonControllingInterests { get; set; }
        public double CommonNetIncome { get; set; }
        public double NetIncome { get; set; }
        public double ConsolidatedIncome { get; set; }
    }
}
