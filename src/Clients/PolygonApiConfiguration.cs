namespace polygon_client_net.Clients;

public class PolygonApiConfiguration
{
    public string ApiKey { get; private set; } = string.Empty;

    public PolygonApiConfiguration(string apiKey)
    {
        ApiKey = apiKey;
    }
}
