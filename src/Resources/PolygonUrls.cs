namespace polygon_client_net.Resources;

public static class PolygonUrls
{
    private static readonly string BASE_URL = "https://api.polygon.io/v3/reference/tickers";
    public static Uri TickerDetails(string ticker) => new($"{BASE_URL}/{ticker}");
}
