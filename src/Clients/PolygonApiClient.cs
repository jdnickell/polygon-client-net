using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http;
using polygon_client_net.Http.Interfaces;
using polygon_client_net.Models;

namespace polygon_client_net.Clients;

public class PolygonApiClient : IPolygonApiClient
{
    private readonly IApiConnector _apiConnector;
    private readonly PolygonApiConfiguration _polygonApiConfiguration;

    public IPaginator DefaultPaginator { get; }
    public ITickerClient Ticker { get; }

    public IStockFinancialsClient StockFinancialsClient { get; }

    public PolygonApiClient(PolygonApiConfiguration polygonApiConfiguration)
    {
        ArgumentException.ThrowIfNullOrEmpty(polygonApiConfiguration.ApiKey);

        _polygonApiConfiguration = polygonApiConfiguration;
        _apiConnector = new ApiConnector(_polygonApiConfiguration);

        DefaultPaginator = polygonApiConfiguration.DefaultPaginator ?? new Paginator();

        Ticker = new TickerClient(_apiConnector);
        StockFinancialsClient = new StockFinancialsClient(_apiConnector);
    }

    public Task<IList<T>> PaginateAll<T>(
        IPaginatable<T> firstPage,
        IPaginator? paginator = null
    )
    {
        return (paginator ?? DefaultPaginator).PaginateAll(firstPage, _apiConnector);
    }
}
