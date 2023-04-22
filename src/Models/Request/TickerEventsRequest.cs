using polygon_client_net.Models.Attributes;

namespace polygon_client_net.Models.Request;

/// <summary>
/// Experimental - Get a timeline of events for the entity associated with the given ticker, CUSIP, or Composite FIGI.
/// </summary>
public class TickerEventsRequest
{
    /// <summary>
    /// Identifier of an asset. This can currently be a Ticker, CUSIP, or Composite FIGI. 
    /// When given a ticker, we return events for the entity currently represented by that ticker. 
    /// To find events for entities previously associated with a ticker, find the relevant identifier using the Ticker Details Endpoint
    /// </summary>
    [QueryParameter("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A comma-separated list of the types of event to include. Currently ticker_change is the only supported event_type. 
    /// Leave blank to return all supported event_types.
    /// </summary>
    [QueryParameter("types")]
    public string? Types { get; set; }
}
