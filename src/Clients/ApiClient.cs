using polygon_client_net.Http;

namespace polygon_client_net.Clients;

public abstract class ApiClient
{
    protected ApiClient(IApiConnector apiConnector)
    {
        ArgumentNullException.ThrowIfNull(apiConnector);
        Api = apiConnector;
    }

    protected IApiConnector Api { get; set; }
}
