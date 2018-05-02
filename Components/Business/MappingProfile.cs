using AnalyticalMarket.Business.Business.AlphaVantage;
using AnalyticalMarket.Entities.Models;
using AnalyticalMarket.Shared.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyticalMarket.Business
{
    public static class MappingProfile
    {
        public static void Configure()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<AlphaQuoteModel, HistoricalQuote>()
                    .ForMember(m => m.AdjustedClose, opt => opt.MapFrom(f => f.adjustedclose))
                    .ForMember(m => m.Close, opt => opt.MapFrom(f => f.close))
                    .ForMember(m => m.High, opt => opt.MapFrom(f => f.high))
                    .ForMember(m => m.Low, opt => opt.MapFrom(f => f.low))
                    .ForMember(m => m.Open, opt => opt.MapFrom(f => f.open))
                    .ForMember(m => m.Volume, opt => opt.MapFrom(f => f.volume))
                    .ForMember(m => m.SplitCoefficient, opt => opt.MapFrom(f => f.splitcoefficient));

                mapper.CreateMap<Stock, StockViewModel>().ReverseMap();
                mapper.CreateMap<HistoricalQuote, HistoricalQuoteViewModel>().ReverseMap();
            });


            
        }
    }
}
