using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticalMarket.Business.Business.Interfaces
{
    public interface IMarketSeeder
    {
        Task SeedStock(string ticker);
        Task SeedProfile(string ticker);
        Task SeedIncomeStatement(string ticker);
        Task SeedBalanceSheet(string ticker);
        Task SeedCashFlow(string ticker);
        Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to);
        Task SeedDividends(string ticker, DateTime? from, DateTime? to);
    }
}
