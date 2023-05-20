using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http;
using polygon_client_net.Http.Interfaces;

namespace polygon_client_net.Clients;

public class PolygonApiClient : IPolygonApiClient
{
    private readonly IApiConnector _apiConnector;
    private readonly PolygonApiConfiguration _polygonApiConfiguration;

    public ITickerClient Ticker { get; }

    public PolygonApiClient(PolygonApiConfiguration polygonApiConfiguration)
    {
        ArgumentException.ThrowIfNullOrEmpty(polygonApiConfiguration.ApiKey);

        _polygonApiConfiguration = polygonApiConfiguration;
        _apiConnector = new ApiConnector(_polygonApiConfiguration);

        Ticker = new TickerClient(_apiConnector);
    }
}
