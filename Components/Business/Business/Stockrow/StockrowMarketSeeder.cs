using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Business.Data.Interfaces;
using AnalyticalMarket.Entities.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AnalyticalMarket.Business.Business.Stockrow
{
    /// <summary>
    /// Source URI: https://stockrow.com
    /// </summary>
    public class StockrowMarketSeeder : IMarketSeeder
    {
        private IHistoricalQuoteRepository _historicalQuoteRepository;
        private const string _baseAddress = "https://stockrow.com/api/";

        #region Constructor

        public StockrowMarketSeeder(IHistoricalQuoteRepository historicalQuoteRepository)
        {
            this._historicalQuoteRepository = historicalQuoteRepository;
        }

        #endregion

        #region IMarket Seeder

        public async Task SeedStock(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedProfile(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedIncomeStatement(string ticker, DateTime? from, DateTime? to)
        {
            var dimension = "MRQ";
            var section = "Income Statement";

            ExcelWorksheet workSheet = await GetExcelStatementAsync(ticker, dimension, section);

            var income10Qs = StockrowFormatter.ParseIncomeStatement(workSheet);

            if (income10Qs == null || !income10Qs.Any())
                throw new Exception("Invalid Excel Worksheet");

            var result = income10Qs.Where(m => (from == null || from <= m.PeriodEnding) && (to == null || m.PeriodEnding <= to)).ToList();
        }

        public async Task SeedBalanceSheet(string ticker, DateTime? from, DateTime? to)
        {
            var dimension = "MRQ";
            var section = "Balance Sheet";

            ExcelWorksheet workSheet = await GetExcelStatementAsync(ticker, dimension, section);

            var balance10Qs = StockrowFormatter.ParseBalanceSheet(workSheet);

            if (balance10Qs == null || !balance10Qs.Any())
                throw new Exception("Invalid Excel Worksheet");

            var result = balance10Qs.Where(m => (from == null || from <= m.PeriodEnding) && (to == null || m.PeriodEnding <= to)).ToList();
        }

        public async Task SeedCashFlow(string ticker, DateTime? from, DateTime? to)
        {
            var dimension = "MRQ";
            var section = "Cash Flow";

            ExcelWorksheet workSheet = await GetExcelStatementAsync(ticker, dimension, section);

            var cash10Qs = StockrowFormatter.ParseCashFlow(workSheet);

            if (cash10Qs == null || !cash10Qs.Any())
                throw new Exception("Invalid Excel Worksheet");

            var result = cash10Qs.Where(m => (from == null || from <= m.PeriodEnding) && (to == null || m.PeriodEnding <= to)).ToList();
        }

        public async Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }

        public async Task SeedDividends(string ticker, DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private async Task<ExcelWorksheet> GetExcelStatementAsync(string ticker, string dimension, string section)
        {
            Stream stream = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);

                var query = HttpUtility.ParseQueryString(string.Empty);
                query["dimension"] = dimension;
                query["section"] = section; 

                var path = $"companies/{ticker}/financials.xlsx?{query.ToString()}";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                    stream = response.Content.ReadAsStreamAsync().Result;
                else
                    throw new Exception("Invalid Request Error");
                
                if (stream == null)
                    throw new Exception("Invalid Request Error");
            }

            ExcelPackage package = new ExcelPackage(stream);
            
            if (package == null)
                throw new Exception("Invalid Request Error");

            return package.Workbook.Worksheets[0];

        }

        #endregion
    }
}
