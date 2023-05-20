namespace polygon_client_net.Clients.Interfaces;

public interface IPolygonApiClient
{
    ITickerClient Ticker { get; }
}
