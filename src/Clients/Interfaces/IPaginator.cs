using polygon_client_net.Http;
using polygon_client_net.Models;

namespace polygon_client_net.Clients.Interfaces;

/// <summary>
/// Allows cycling through all resources of a response
/// </summary>
internal interface IPaginator
{
    /// <summary>
    /// Fetches all pages and returns them in a single list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="firstPage">The first page of results - will be included in returned list.</param>
    /// <param name="connector">The Api connector for making requests to Polygon.</param>
    /// <param name="cancel">The cancellation token to cancel the request.</param>
    /// <returns>A list containing all pages</returns>
    Task<IList<T>> PaginateAll<T>(IPaginatable<T> firstPage, ApiConnector connector, CancellationToken cancel = default);
}
