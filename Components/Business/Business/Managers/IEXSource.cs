using System;
using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Shared.Enums;

namespace AnalyticalMarket.Business.Business.Managers
{
    public class IEXSource : IEMarket
    {
        public long AverageVolume(string symbol, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public double Beta(string symbol)
        {
            throw new NotImplementedException();
        }

        public double Close(string symbol, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public double Dividend(string symbol, Quarter quarter, int year)
        {
            throw new NotImplementedException();
        }

        public double High(string symbol, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public double Low(string symbol, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public long MarketCap(string symbol)
        {
            throw new NotImplementedException();
        }

        public double Open(string symbol, DateTime? fromDate = null)
        {
            throw new NotImplementedException();
        }

        public long Volume(string symbol, DateTime? date = null)
        {
            throw new NotImplementedException();
        }
    }



}