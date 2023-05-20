using polygon_client_net.Clients;
using polygon_client_net.Http.Interfaces;
using System.Text.Json;

namespace polygon_client_net.Http;

public class ApiConnector : IApiConnector
{
    private readonly IHttpClient _polygonHttpClient;

    public ApiConnector(PolygonApiConfiguration configuration) : this(configuration, new PolygonHttpClient() ) 
    {
    }

    public ApiConnector(PolygonApiConfiguration configuration, IHttpClient polygonHttpClient)
    {
        _polygonHttpClient = polygonHttpClient;
        _polygonHttpClient.SetBearerToken(configuration.ApiKey);
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

    public async Task<T> SendAPIRequestAsync<T>(Uri uri, 
        HttpMethod method, 
        IDictionary<string, string>? parameters = null, 
        CancellationToken cancel = default)
    {
        ArgumentNullException.ThrowIfNull(uri);
        var response = await _polygonHttpClient.DoRequestAsync(uri, parameters, method, cancel);
        var jsonSerializerOptions = new JsonSerializerOptions { PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy() };
        var responseDeserialized = JsonSerializer.Deserialize<T>(response.Body.ToString(), jsonSerializerOptions);

        return responseDeserialized;
    }

    public void SetRequestTimeout(TimeSpan timeout)
    {
        // TODO
        throw new NotImplementedException();
    }
}
