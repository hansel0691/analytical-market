using AnalyticalMarket.Shared.Enums;
using System;


namespace AnalyticalMarket.Business.Business.Interfaces
{
    /// <summary>
    /// Provides constants and static methods for common market functions.
    /// </summary>
    public interface IEMarket
    {

        /// <summary>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the closing price for a symbol on a specific date.</returns>
        double Close(string symbol, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the open price for a symbol on a specific date.</returns>
        double Open(string symbol, DateTime? fromDate = null);
        /// <summary>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the highest price for a symbol on a specific date.</returns>
        double High(string symbol, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the lowest price for a symbol on a specific date.</returns>
        double Low(string symbol, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the volume for a symbol on a specific date.</returns>
        long Volume(string symbol, DateTime? date = null);

        /// <summary>
        ///  Total dollar market value of a company's outstanding shares
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        long MarketCap(string symbol);

        /// <summary>
        /// Dividend paid by a stock on a specific quarter.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="quarter"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        double Dividend(string symbol, Quarter quarter, int year);

        /// <summary>
        /// Volatility or systematic risk of a stock in comparison to the market as a whole.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        double Beta(string symbol);

        long AverageVolume(string symbol, DateTime? date = null);

    }
}