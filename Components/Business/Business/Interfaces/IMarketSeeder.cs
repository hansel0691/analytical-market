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
        Task SeedIncomeStatement(string ticker, DateTime? from, DateTime? to);
        Task SeedBalanceSheet(string ticker, DateTime? from, DateTime? to);
        Task SeedCashFlow(string ticker, DateTime? from, DateTime? to);
        Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to);
        Task SeedDividends(string ticker, DateTime? from, DateTime? to);
    }
}
