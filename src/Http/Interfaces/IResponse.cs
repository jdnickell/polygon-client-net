using System.Net;

namespace polygon_client_net.Http.Interfaces
{
    public interface IResponse
    {
        object? Body { get; }

        HttpStatusCode StatusCode { get; }

        string? ContentType { get; }
    }
}
