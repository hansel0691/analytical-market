using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Business.Interfaces
{
    public interface IMarketSeeder
    {
        void SeedStock(string symbol);
        void SeedProfile(string symbol);
        void SeedIncomeStatement(string symbol);
        void SeedBalanceSheet(string symbol);
        void SeedCashFlow(string symbol);
        void SeedHistoricalData(string symbol, DateTime from, DateTime to);
    }
}
