using polygon_client_net.Clients.Interfaces;

namespace polygon_client_net.Clients;

public class PolygonApiConfiguration
{
    public string ApiKey { get; private set; } = string.Empty;
    public IPaginator? DefaultPaginator { get; private set; }

    public PolygonApiConfiguration(string apiKey, IPaginator? defaultPaginator = null)
    {
        ApiKey = apiKey;
        DefaultPaginator = defaultPaginator;
    }
}
