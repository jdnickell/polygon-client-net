﻿using polygon_client_net.Models.Attributes;
using System.Globalization;

namespace polygon_client_net.Models.Request
{
    public class StockFinancialsRequest : RequestParameters
    {
        /// <summary>
        /// Query by company ticker.
        /// </summary>
        public string? Ticker { get; set; }

        [QueryParameter("ticker")]
        protected string? TickerFormatted
        {
            get => Ticker?.ToUpper();
        }

        /// <summary>
        /// Query by central index key (CIK) Number.
        /// Reference https://www.sec.gov/edgar/searchedgar/cik
        /// </summary>
        [QueryParameter("cik")]
        public int? Cik { get; set; }

        /// <summary>
        /// Query by company name.
        /// </summary>
        [QueryParameter("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Query by standard industrial classification (SIC).
        /// Reference https://www.sec.gov/corpfin/division-of-corporation-finance-standard-industrial-classification-sic-code-list
        /// </summary>
        [QueryParameter("sic")]
        public int? Sic { get; set; }

        /// <summary>
        /// Query by the date when the filing with financials data was filed in YYYY-MM-DD format.
        /// </summary>
        /// <remarks>
        /// Best used when querying over date ranges to find financials based on filings that happen in a time period.
        /// Examples:
        /// To get financials based on filings that have happened after January 1, 2009 use the query param filing_date.gte=2009-01-01
        /// To get financials based on filings that happened in the year 2009 use the query params filing_date.gte=2009-01-01&filing_date.lt=2010-01-01
        /// </remarks>
        public DateOnly FilingDate { get; set; }

        [QueryParameter("filing_date.gte")] // TODO - hard coded >= for now
        protected string? FilingDateFormatted
        {
            get => FilingDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        // TODO: Implement base for - https://polygon.io/blog/api-pagination-patterns/
        // filing_date.ltless than
        // filing_date.lteless than or equal to
        // filing_date.gtgreater than
        // filing_date.gtegreater than or equal to

        // <summary>
        // The period of report for the filing with financials data in YYYY-MM-DD format.
        // The Polygon REST docs don't give anymore information about this parameter, but it seems like this is an annual occurrence.
        // </summary>
        public DateOnly PeriodOfReportDate { get; set; }

        [QueryParameter("period_of_report_date.gte")] // TODO - hard coded >= for now
        protected string? PeriodOfReportDateFormatted
        {
            get => PeriodOfReportDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public Timeframe? Timeframe { get; set; }

        /// <summary>
        /// Query by timeframe. Annual financials originate from 10-K filings, and quarterly financials originate from 10-Q filings. 
        /// </summary>
        /// <remarks>
        /// Note: Most companies do not file quarterly reports for Q4 and instead include those financials in their annual report, 
        /// so some companies my not return quarterly financials for Q4
        /// </remarks>
        [QueryParameter("timeframe")]
        public string? TimeframeFormatted
        {
            get => Timeframe?.ToString().ToLower();
        }

        /// <summary>
        /// Whether or not to include the xpath and formula attributes for each financial data point. See the xpath and formula response attributes for more info. False by default.
        /// </summary>
        [QueryParameter("include_sources")]
        public bool? IncludeSources { get; set; }

        /// <summary>
        /// Limit the number of results returned, default is 10 and max is 100.
        /// </summary>
        [QueryParameter("limit")]
        public int? Limit { get; set; }

        // TODO: Order/Sort
        // add sort enums
        [QueryParameter("sort")]
        public string? Sort { get; set; }
    }

    public enum Timeframe
    {
        Annual,
        Quarterly,
        Ttm
    }
}
