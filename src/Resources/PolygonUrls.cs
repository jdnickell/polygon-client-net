namespace polygon_client_net.Resources;

public static class PolygonUrls
{
    #region Reference Data Endpoints

    private static readonly string REFERENCE_DATA_ENDPOINTS_BASE_URL = "https://api.polygon.io/v3/reference";
    public static Uri TickerDetails(string ticker) => new($"{REFERENCE_DATA_ENDPOINTS_BASE_URL}/tickers/{ticker}");
    public static Uri Tickers => new($"{REFERENCE_DATA_ENDPOINTS_BASE_URL}/tickers");

    #endregion

}
