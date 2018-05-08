using AnalyticalMarket.Business.Business.Stockrow;
using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace AnalyticalMarket.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetResult().Result;
        }

        private static async Task<int> GetResult() {
            var seeder = new StockrowMarketSeeder(null);
            await seeder.SeedIncomeStatement("QCOM", DateTime.Parse("01-01-2018"), null);

            return 0;
        } 
    }
}
