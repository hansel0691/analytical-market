using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Business.Data.Interfaces;
using AnalyticalMarket.Entities.Models;
using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Linq;

namespace AnalyticalMarket.Business.Business.AlphaVantage
{
    /// <summary>
    /// Source URI: https://www.alphavantage.co
    /// </summary>
    public class AlphaMarketSeeder : IMarketSeeder
    {
        private IHistoricalQuoteRepository _historicalQuoteRepository;
        private const string _baseAddress = "https://www.alphavantage.co";

        #region Constructor

        public AlphaMarketSeeder(IHistoricalQuoteRepository historicalQuoteRepository)
        {
            this._historicalQuoteRepository = historicalQuoteRepository;
        }

        #endregion

        #region IMarket Seeder

        public async Task SeedBalanceSheet(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedCashFlow(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to)
        {
            var api_key = "8QZNUXFHZ9G9M3K2";
            var result = new List<HistoricalQuote>();
            var dailyHistorical = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                var query = HttpUtility.ParseQueryString(string.Empty);
                query["function"] = "TIME_SERIES_DAILY_ADJUSTED";
                query["symbol"] = ticker;
                //TODO HG - Find better way
                query["outputsize"] = from == null || (DateTime.Now - from.Value).TotalDays > 100 ? "full" : "compact";
                query["apikey"] = api_key;

                var path = $"/query?{query.ToString()}";
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                    dailyHistorical = response.Content.ReadAsStringAsync().Result;
                else
                    throw new Exception("Invalid Request Error");

                if (string.IsNullOrEmpty(dailyHistorical))
                    throw new Exception("Invalid Request Error");
            }

            dailyHistorical = GetDateToDateSerie(Regex.Replace(dailyHistorical, @"\""|\s|\d\.\s", ""), from, to);

            //TODO HG - Find a better way to do this 
            var lines = Regex.Replace(dailyHistorical, "},", "}|").Split("|");

            foreach (var q in lines)
            {
                var quoteDetail = Regex.Replace(q, ":{", "|{").Split("|");
                var quoteDate = DateTime.ParseExact(quoteDetail[0], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                if ((from == null || from.Value <= quoteDate) && (to == null || to.Value >= quoteDate))
                {
                    var quote = JsonConvert.DeserializeObject<AlphaQuoteModel>(quoteDetail[1]);
                    HistoricalQuote model = Mapper.Map<HistoricalQuote>(quote);

                    model.Date = quoteDate;
                    //TODO HG - Set stockId Id

                    result.Add(model);
                }
            }
        }

        public async Task SeedIncomeStatement(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedProfile(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedStock(string ticker)
        {
            throw new NotImplementedException();
        }

        public async Task SeedDividends(string ticker, DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private string GetDateToDateSerie(string dailyHistorical, DateTime? from, DateTime? to)
        {

            if (string.IsNullOrEmpty(dailyHistorical))
                throw new ArgumentException("Invalid dailyHistorical argument");


            int startIndex = to == null ? dailyHistorical.IndexOf("TimeSeries(Daily)") + 19 : -1;
            for (var i = 0;  to != null && startIndex == -1 && i < 100; i++)
                startIndex = dailyHistorical.LastIndexOf((to.Value.AddDays(-1 *i)).ToString("yyyy-MM-dd"));

            if (startIndex <= 23)
                throw new Exception("Can't find the beginning of serie");

            int length = from == null ? dailyHistorical.Length - startIndex - 2 : 0;
            for (var i = 1;  from != null && length == 0 && i < 100; i++)
            {
                int index = dailyHistorical.LastIndexOf((from.Value.AddDays(-1*i)).ToString("yyyy-MM-dd"));

                if (index != -1)
                    length = index - startIndex - 1;
            }

            if (length <= 0)
                throw new Exception("Can't find end of serie");

            return dailyHistorical.Substring(startIndex, length);

        }

        #endregion

    }
}
