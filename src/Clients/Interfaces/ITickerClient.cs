using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;

namespace polygon_client_net.Clients.Interfaces
{
    public interface ITickerClient
    {
        public Task<TickersResponse> GetTickerDetails(string ticker, TickerDetailsRequest tickersRequest, CancellationToken cancel = default);
    }
}
