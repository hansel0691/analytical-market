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
        /// <param name="ticker"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the closing price for a ticker on a specific date.</returns>
        double Close(string ticker, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the open price for a ticker on a specific date.</returns>
        double Open(string ticker, DateTime? fromDate = null);
        /// <summary>
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the highest price for a ticker on a specific date.</returns>
        double High(string ticker, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the lowest price for a ticker on a specific date.</returns>
        double Low(string ticker, DateTime? date = null);
        /// <summary>
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date">Last traded date if none is specified</param>
        /// <returns>Returns the volume for a ticker on a specific date.</returns>
        long Volume(string ticker, DateTime? date = null);

        /// <summary>
        ///  Total dollar market value of a company's outstanding shares
        /// </summary>
        /// <param name="ticker"></param>
        /// <returns></returns>
        long MarketCap(string ticker);

        /// <summary>
        /// Dividend paid by a stock on a specific quarter.
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="quarter"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        double Dividend(string ticker, Quarter quarter, int year);

        /// <summary>
        /// Volatility or systematic risk of a stock in comparison to the market as a whole.
        /// </summary>
        /// <param name="ticker"></param>
        /// <returns></returns>
        double Beta(string ticker);

        long AverageVolume(string ticker, DateTime? date = null);

    }
}