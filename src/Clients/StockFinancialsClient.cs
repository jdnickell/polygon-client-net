using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http.Interfaces;
using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;
using polygon_client_net.Resources;

namespace polygon_client_net.Clients
{
    public class StockFinancialsClient : ApiClient, IStockFinancialsClient
    {
        public StockFinancialsClient(IApiConnector apiConnector) : base(apiConnector)
        {
        }

        /// <inheritdoc/>
        public async Task<Paging<StockFinancialsResponse>> GetStockFinancialsAsync(StockFinancialsRequest stockFinancialsRequest, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stockFinancialsRequest);
            return await Api.Get<Paging<StockFinancialsResponse>>(PolygonUrls.StockFinancials, stockFinancialsRequest.BuildQueryParams(), cancellationToken);
        }
    }
}
