namespace polygon_client_net.Http.Interfaces
{
    public interface IHttpClient : IDisposable
    {
        Task<IResponse> DoRequestAsync(Uri endpoint, IDictionary<string, string> parameters, HttpMethod httpMethod, CancellationToken cancel = default);

        void SetRequestTimeout(TimeSpan timeout);
    }
}
