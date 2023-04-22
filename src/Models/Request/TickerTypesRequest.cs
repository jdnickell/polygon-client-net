using polygon_client_net.Models.Attributes;

namespace polygon_client_net.Models.Request;

/// <summary>
/// List all ticker types that Polygon.io has.
/// </summary>
public class TickerTypesRequest
{
    /// <summary>
    /// Filter by asset class.
    /// </summary>
    [QueryParameter("asset_class")]
    public string? AssetClass { get; set; }
    // TODO: options: stocks, options, crypto, fx, indices

    /// <summary>
    /// Filter by locale.
    /// </summary>
    [QueryParameter("locale")]
    public string? Locale { get; set; }
    // TODO: options: us,Global
}
