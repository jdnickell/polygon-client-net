using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;

namespace polygon_client_net.Clients.Interfaces
{
    public interface ITickerClient
    {
        public Task<TickerDetailsResponse> GetTickerDetailsAsync(string ticker, TickerDetailsRequest tickerDetailsRequest, CancellationToken cancel = default);
    }
}
