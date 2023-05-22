using polygon_client_net.Models.Request;
using polygon_client_net.Models.Response;

namespace polygon_client_net.Clients.Interfaces;

public interface IStockFinancialsClient
{
    /// <summary>
    /// Get historical financial data for a stock ticker. The financials data is extracted from XBRL from company SEC filings using the methodology.
    /// Outlined here: http://xbrl.squarespace.com/understanding-sec-xbrl-financi/
    /// </summary>
    /// <param name="stockFinancialsRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task<Paging<StockFinancialsResponse>> GetStockFinancialsAsync(StockFinancialsRequest stockFinancialsRequest, CancellationToken cancellationToken = default);
}
