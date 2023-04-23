using polygon_client_net.Http.Interfaces;
using System.Net;

namespace polygon_client_net.Http;

public class Response : IResponse
{
    public object? Body { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public string? ContentType { get; set; }
}
