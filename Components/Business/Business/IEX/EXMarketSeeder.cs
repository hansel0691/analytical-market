using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Business.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticalMarket.Business.Business.IEX
{
    /// <summary>
    /// https://api.iextrading.com/1.0
    /// </summary>
    public class EXMarketSeeder : IMarketSeeder
    {
        private IHistoricalQuoteRepository _historicalQuoteRepository;
        private const string _baseAddress = "https://api.iextrading.com/1.0";

        #region Constructor

        public EXMarketSeeder(IHistoricalQuoteRepository historicalQuoteRepository)
        {
            this._historicalQuoteRepository = historicalQuoteRepository;
        }

        #endregion
        #region IMarket Seeder


        public void SeedBalanceSheet(string ticker)
        {
            /*/stock/{symbol}/financials*/
            throw new NotImplementedException();
        }
        
        public void SeedCashFlow(string ticker)
        {
            /*/stock/{symbol}/financials*/
            throw new NotImplementedException();
        }

        public Task SeedHistoricalQuote(string ticker, DateTime? from, DateTime? to)
        {
            throw new NotImplementedException();
        }

        public void SeedIncomeStatement(string ticker)
        {
            /*/stock/{symbol}/financials*/
            throw new NotImplementedException();
        }

        public void SeedProfile(string ticker)
        {
        /*
         * https://api.iextrading.com/1.0/stock/aapl/company
           https://api.iextrading.com/1.0/stock/aapl/peers
        */
            throw new NotImplementedException();
        }

        public void SeedStock(string ticker)
        {
            throw new NotImplementedException();
        }

        public Task SeedDividends(string ticker, DateTime? from, DateTime? to)
        {
            /*
             * GET /stock/{symbol}/dividends/{range}
            */

            throw new NotImplementedException();
        }

        #endregion
    }
}
