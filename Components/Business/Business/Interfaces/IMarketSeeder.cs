using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticalMarket.Business.Business.Interfaces
{
    public interface IMarketSeeder
    {
        void SeedStock(string ticker);
        void SeedProfile(string ticker);
        void SeedIncomeStatement(string ticker);
        void SeedBalanceSheet(string ticker);
        void SeedCashFlow(string ticker);
        Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to);
        Task SeedDividends(string ticker, DateTime? from, DateTime? to);
    }
}
