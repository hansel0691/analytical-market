using AnalyticalMarket.Business.Data.Interfaces;
using AnalyticalMarket.Entities;
using AnalyticalMarket.Entities.Models;
using Blank.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business.Data.Repositories
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(MarketDbContext context) : base(context)
        {
        }
    }
}
