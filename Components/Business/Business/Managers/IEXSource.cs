using System;
using AnalyticalMarket.Business.Business.Interfaces;
using AnalyticalMarket.Shared.Enums;

namespace AnalyticalMarket.Business.Business.Managers
{
    public class IEXSource : IEMarket
    {
        public long AverageVolume(string ticker, DateTime? date = null)
        {
            throw new NotImplementedException();
        }
        
        public double Beta(string ticker)
        {
            throw new NotImplementedException();
        }

        public double Close(string ticker, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public double Dividend(string ticker, Quarter quarter, int year)
        {
            throw new NotImplementedException();
        }

        public double High(string ticker, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public double Low(string ticker, DateTime? date = null)
        {
            throw new NotImplementedException();
        }

        public long MarketCap(string ticker)
        {
            throw new NotImplementedException();
        }

        public double Open(string ticker, DateTime? fromDate = null)
        {
            throw new NotImplementedException();
        }

        public long Volume(string ticker, DateTime? date = null)
        {
            throw new NotImplementedException();
        }
    }



}