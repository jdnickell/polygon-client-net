using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http;
using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;
using polygon_client_net.Resources;

namespace polygon_client_net.Clients;

public class TickerClient : ApiClient, ITickerClient
{
    public TickerClient(IApiConnector apiConnector) : base(apiConnector)
    {
    }

    public Task<TickersResponse> GetTickerDetails(string ticker, TickerDetailsRequest tickersRequest, CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(tickersRequest);
        return Api.Get<TickersResponse>(PolygonUrls.TickerDetails(ticker), tickersRequest.BuildQueryParams(), cancel);
    }
}
