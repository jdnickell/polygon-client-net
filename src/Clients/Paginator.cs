﻿using polygon_client_net.Clients.Interfaces;
using polygon_client_net.Http.Interfaces;
using polygon_client_net.Models;
using polygon_client_net.Models.Response;

namespace polygon_client_net.Clients;

/// <inheritdoc />
public class Paginator : IPaginator
{
    protected virtual Task<bool> ShouldContinue<T>(List<T> results, IPaginatable<T> page)
    {
        return Task.FromResult(true);
    }

    /// <inheritdoc />
    public async Task<Paging<T>> Paginate<T>(string nextUrl, IApiConnector connector, CancellationToken cancel = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(nextUrl);
        ArgumentNullException.ThrowIfNull(connector);

        var page = await connector.Get<Paging<T>>(new Uri(nextUrl, UriKind.Absolute), cancel).ConfigureAwait(false);
        return page;
    }

    /// <inheritdoc/>
    public async Task<IList<T>> PaginateAll<T>(IPaginatable<T> firstPage, IApiConnector connector, CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(firstPage);
        ArgumentNullException.ThrowIfNull(connector);

        var page = firstPage;
        var results = new List<T>();
        if (page.Results != null)
        {
            results.AddRange(page.Results);
        }

        while (page.NextUrl != null && await ShouldContinue(results, page).ConfigureAwait(false))
        {
            page = await connector.Get<Paging<T>>(new Uri(page.NextUrl, UriKind.Absolute), cancel).ConfigureAwait(false);
            if (page.Results != null)
            {
                results.AddRange(page.Results);
            }
        }

        return results;
    }
}
