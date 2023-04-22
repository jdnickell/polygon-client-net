using System.Net;

namespace polygon_client_net.Http
{
    internal interface IApiConnector
    {
        event EventHandler<IResponse>? ResponseReceived;

        Task<T> Get<T>(Uri uri, CancellationToken cancel = default);
        Task<T> Get<T>(Uri uri, IDictionary<string, string>? parameters, CancellationToken cancel = default);
        Task<HttpStatusCode> Get(Uri uri, IDictionary<string, string>? parameters, object? body, CancellationToken cancel = default);

        Task<T> SendAPIRequest<T>(
          Uri uri, HttpMethod method,
          IDictionary<string, string>? parameters = null,
          object? body = null,
          IDictionary<string, string>? headers = null,
          CancellationToken cancel = default);

        void SetRequestTimeout(TimeSpan timeout);
    }
}
