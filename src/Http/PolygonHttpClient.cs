using polygon_client_net.Http.Interfaces;
using polygon_client_net.Resources;

namespace polygon_client_net.Http;

public class PolygonHttpClient : IHttpClient
{
    private readonly HttpClient _httpClient;

    public PolygonHttpClient()
    {
        _httpClient = new HttpClient();
    }

    public PolygonHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _httpClient?.Dispose();
        }
    }

    public async Task<IResponse> DoRequestAsync(Uri endpoint, 
        IDictionary<string, string> parameters, 
        HttpMethod httpMethod, 
        CancellationToken cancellationToken = default)
    {
        using var httpRequestMessage = GetRequestMessage(endpoint, parameters, httpMethod);

        var responseMessage = await _httpClient
            .SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, cancellationToken)
            .ConfigureAwait(false);

        var body = await responseMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        using var content = responseMessage.Content;
        var contentType = content.Headers?.ContentType?.MediaType;

        var response = new Response
        {
            Body = body,
            ContentType = contentType,
            StatusCode = responseMessage.StatusCode
        };

        return response;
    }

    public void SetRequestTimeout(TimeSpan timeout)
    {
        throw new NotImplementedException();
    }

    private static HttpRequestMessage GetRequestMessage(Uri endpoint, IDictionary<string, string> parameters, HttpMethod httpMethod)
    {
        var uri = new Uri(endpoint.ToString()).ApplyParameters(parameters);
        var httpRequestMessage = new HttpRequestMessage(httpMethod, uri);

        return httpRequestMessage;
    }
}
