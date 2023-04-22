using polygon_client_net.Models.Attributes;
using System.Globalization;

namespace polygon_client_net.Models.Request;

/// <summary>
/// Get the most recent news articles relating to a stock ticker symbol, including a summary of the article and a link to the original source.
/// </summary>
public class TickerNewsRequest
{
    /// <summary>
    /// Return results that contain this ticker.
    /// </summary>
    [QueryParameter("ticker")]
    public string? Ticker { get; set; }

    /// <summary>
    /// Return results published on, before, or after this date.
    /// </summary>
    public DateTime PublishedUtc { get; set; }

    [QueryParameter("published_utc")]
    protected string? TimestampFormatted
    {
        get => PublishedUtc.ToString("o", CultureInfo.InvariantCulture);
    }

    //TODO: Order/Limit/Sort
}
