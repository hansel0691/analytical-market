using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities.Models
{
    public class CashFlow
    {
        public DateTime PeriodEnding { get; set; }
        public double Depreciation_Amortization { get; set; }
        public double ShareBasedCompensation { get; set; }
        public double OperatingCashFlow { get; set; }
        public double CapitalExpenditure { get; set; }
        public double BusinessAcquisitions_Disposals { get; set; }
        public double InvestmentAcquisitions_Disposals { get; set; }
        public double InvestingCashFlow { get; set; }
        public double DebtSecuritiesRepayment { get; set; }
        public double EquitySharesPurchase { get; set; }
        public double DividendsPayment_Distributions { get; set; }
        public double FinancingCashFlow { get; set; }
        public double FreeCashFlow { get; set; }

    }
}
