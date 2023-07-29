using polygon_client_net.Http.Interfaces;
using polygon_client_net.Models;
using polygon_client_net.Models.Response;

namespace polygon_client_net.Clients.Interfaces;

/// <summary>
/// Allows cycling through all resources of a response
/// </summary>
public interface IPaginator
{
    /// <summary>
    /// Fetches a next page of results.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="nextUrl">The next url given by a previous page of results.</param>
    /// <param name="connector">The Api connector for making requests to Polygon.</param>
    /// <param name="cancel">The cancellation token to cancel the request.</param>
    /// <returns></returns>
    public Task<Paging<T>> Paginate<T>(string nextUrl, IApiConnector connector, CancellationToken cancel = default);

    /// <summary>
    /// Fetches all pages and returns them in a single list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="firstPage">The first page of results - will be included in returned list.</param>
    /// <param name="connector">The Api connector for making requests to Polygon.</param>
    /// <param name="cancel">The cancellation token to cancel the request.</param>
    /// <returns>A list containing all pages</returns>
    Task<IList<T>> PaginateAll<T>(IPaginatable<T> firstPage, IApiConnector connector, CancellationToken cancel = default);
}
