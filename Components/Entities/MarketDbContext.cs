using AnalyticalMarket.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Entities
{
    public class MarketDbContext: DbContext
    {
        public MarketDbContext()
        {
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<HistoricalQuote> HistoricalQuotes { get; set; }
    }
}
