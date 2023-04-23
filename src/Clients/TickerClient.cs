using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http.Interfaces;
using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;
using polygon_client_net.Resources;

namespace polygon_client_net.Clients;

public class TickerClient : ApiClient, ITickerClient
{
    public TickerClient(IApiConnector apiConnector) : base(apiConnector)
    {
    }

    public async Task<TickerDetailsResponse> GetTickerDetailsAsync(string ticker, TickerDetailsRequest tickerDetailsRequest, CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(tickerDetailsRequest);
        return await Api.Get<TickerDetailsResponse>(PolygonUrls.TickerDetails(ticker), tickerDetailsRequest.BuildQueryParams(), cancel);
    }
}
