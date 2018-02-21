using AnalyticalMarket.Entities.Models;
using AnalyticalMarket.Shared.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.UI
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Stock, StockViewModel>().ReverseMap();
            CreateMap<HistoricalQuote, HistoricalQuoteViewModel>().ReverseMap();
        }
    }
}
