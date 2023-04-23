using polygon_client_net.Models.Attributes;
using System.Globalization;

namespace polygon_client_net.Models.Request;

/// <summary>
/// Get a single ticker supported by Polygon.io. This response will have detailed information about the ticker and the company behind it.
/// </summary>
public class TickerDetailsRequest : RequestParameters
{
    /// <summary>
    /// Specify a point in time to get information about the ticker available on that date. 
    /// When retrieving information from SEC filings, we compare this date with the period of report date on the SEC filing.
    /// Defaults to the most recent available date if null.
    /// </summary>
    public DateOnly Date { get; set; }

    [QueryParameter("Date")]
    protected string? DateFormatted
    {
        get => Date.ToString("MM-dd-yyy", CultureInfo.InvariantCulture);
    }
}
