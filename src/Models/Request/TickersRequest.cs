using polygon_client_net.Models.Attributes;

namespace polygon_client_net.Models.Request
{
    public class TickersRequest
    {
        /// <summary>
        /// Specify a ticker symbol. Defaults to empty string which queries all tickers.
        /// </summary>
        [QueryParameter("ticker")]
        public string? Ticker { get; set; }

        /// <summary>
        /// Specify the type of the tickers. Find the supported types via the TickerType request.
        /// </summary>
        [QueryParameter("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Filter by market type. By default all markets are included.
        /// </summary>
        [QueryParameter("market")]
        public MarketType? MarketType { get; set; }

        /// <summary>
        /// Specify the primary exchange of the asset in the ISO code format. Find more information about the ISO codes at the ISO org website. 
        /// Defaults to empty string which queries all exchanges.
        /// </summary>
        [QueryParameter("exchange")]
        public string? Exchange { get; set; }

        /// <summary>
        /// Specify the CUSIP code of the asset you want to search for.
        /// Defaults to empty string which queries all CUSIPs.
        /// </summary>
        [QueryParameter("cusip")]
        public string? Cusip { get; set; }

        /// <summary>
        /// Specify the CIK of the asset you want to search for.
        /// Defaults to empty string which queries all CIKs.
        /// </summary>
        [QueryParameter("cik")]
        public string? CentralIndexKey { get; set; }

        /// <summary>
        /// Specify a point in time to retrieve tickers available on that date.
        /// Defaults to the most recent available date.
        /// </summary>
        [QueryParameter("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Search for terms within the ticker and/or company name.
        /// </summary>
        [QueryParameter("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Specify if the tickers returned should be actively traded on the queried date. 
        /// Default is true.
        /// </summary>
        [QueryParameter("active")]
        public bool IsActive { get; set; }

        //TODO: Order/Limit/Sort
    }

    public enum MarketType
    {
        Stocks,
        Crypto,
        Fx,
        Otc,
        Indices
    }
}
