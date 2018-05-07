using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Business.Data.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AnalyticalMarket.Business.Business.Stockrow
{
    /// <summary>
    /// Source URI: https://stockrow.com/api
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

        public async Task SeedIncomeStatement(string ticker)
        {
            var dimension = "MRQ";
            var section = "Income Statement";

            ExcelWorksheet workSheet = await GetExcelStatementAsync(ticker, dimension, section);


            for (int i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
            {
                for (int j = workSheet.Dimension.Start.Column; j <= workSheet.Dimension.End.Column; j++)
                {
                    object cellValue = workSheet.Cells[i, j].Value;
                }
            }

            throw new NotImplementedException();
        }

        public async Task SeedBalanceSheet(string ticker)
        {
            var dimension = "MRQ";
            var section = "Balance Sheet";

            ExcelWorksheet workSheet = await GetExcelStatementAsync(ticker, dimension, section);

            throw new NotImplementedException();
        }

        public async Task SeedCashFlow(string ticker)
        {
            throw new NotImplementedException();
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

            using (ExcelPackage package = new ExcelPackage(stream))
            {
                if (package == null)
                    throw new Exception("Invalid Request Error");

                return package.Workbook.Worksheets[0];
            }
                
        }

        #endregion
    }
}
