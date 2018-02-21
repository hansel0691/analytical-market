using AnalyticalMarket.Entities.Models;
using Blank.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticalMarket.Business.Data.Interfaces
{
    public interface IHistoricalQuoteRepository : IRepository<HistoricalQuote>
    {
    }
}
