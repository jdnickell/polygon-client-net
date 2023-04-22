namespace polygon_client_net.Http
{
    public interface zIHTTPClient : IDisposable
    {
        Task<IResponse> DoRequest(IRequest request, CancellationToken cancel = default);

        void SetRequestTimeout(TimeSpan timeout);
    }
}
