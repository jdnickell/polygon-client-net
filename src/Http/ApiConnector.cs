using polygon_client_net.Http.Interfaces;
using System.Net;
using System.Text.Json;

namespace polygon_client_net.Http;

public class ApiConnector : IApiConnector
{
    private readonly IHttpClient _polygonHttpClient;

    public ApiConnector() : this( new PolygonHttpClient() ) { }

    public ApiConnector(IHttpClient polygonHttpClient)
    {
        _polygonHttpClient = polygonHttpClient;
    }

    public async Task<T> Get<T>(Uri uri, CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(uri);
        return await SendAPIRequestAsync<T>(uri, HttpMethod.Get, cancel: cancel);
    }

    public async Task<T> Get<T>(Uri uri, IDictionary<string, string>? parameters, CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(uri);
        ArgumentNullException.ThrowIfNull(parameters);
        return await SendAPIRequestAsync<T>(uri, HttpMethod.Get, parameters, cancel: cancel);
    }

    public Task<HttpStatusCode> Get(Uri uri, IDictionary<string, string>? parameters, object? body, CancellationToken cancel = default)
    {
        // TODO, probably don't need this
        throw new NotImplementedException();
    }

    public async Task<T> SendAPIRequestAsync<T>(Uri uri, 
        HttpMethod method, 
        IDictionary<string, string>? parameters = null, 
        CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(uri);
        ArgumentNullException.ThrowIfNull(parameters);
        var response = await _polygonHttpClient.DoRequestAsync(uri, parameters, method, cancel);

        // TODO Exception handling, return some defined exception the caller can expect and handle
        // TODO: snake case -> pascal case deserializer 
        var responseDeserialized = JsonSerializer.Deserialize<T>(response.Body.ToString());
        return responseDeserialized;
    }

    public void SetRequestTimeout(TimeSpan timeout)
    {
        // TODO
        throw new NotImplementedException();
    }
}
