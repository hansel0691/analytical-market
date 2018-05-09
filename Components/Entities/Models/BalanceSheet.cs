using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities.Models
{
    public class BalanceSheet
    {
        public int Id { get; set; }
        public DateTime PeriodEnding { get; set; }
        public double Cash_Equivalents { get; set; }
        public double CurrentInvestments { get; set; }
        public double Investments { get; set; }
        public double NetReceivables { get; set; }
        public double Inventory { get; set; }
        public double CurrentAssets { get; set; }
        public double Property_Equipment { get; set; }
        public double Goodwill_IntangibleAssets { get; set; }
        public double TaxAssets { get; set; }
        public double NonCurrentAssets { get; set; }
        public double TotalAssets { get; set; }
        public double AccountsPayables { get; set; }
        public double CurrentDebt { get; set; }
        public double CurrentLiabilities { get; set; }
        public double NonCurrentLiabilities { get; set; }
        public double TotalDebt { get; set; }
        public double DeferredRevenue { get; set; }
        public double TaxLiabilities { get; set; }
        public double DepositLiabilities { get; set; }
        public double TotalLiabilities { get; set; }
        public double RetainedEarnings { get; set; }
        public double ShareholdersEquity { get; set; }

    }
}
