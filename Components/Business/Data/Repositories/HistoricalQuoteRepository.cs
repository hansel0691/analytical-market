using AnalyticalMarket.Business.Data.Interfaces;
using AnalyticalMarket.Entities;
using AnalyticalMarket.Entities.Models;
using Blank.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Data.Repositories
{
    public class HistoricalQuoteRepository : Repository<HistoricalQuote>, IHistoricalQuoteRepository
    {
        public HistoricalQuoteRepository(MarketDbContext context) : base(context)
        {
        }

    }
}
