namespace polygon_client_net.Clients
{
    public class PolygonApiClientBuilder
    {
        private readonly PolygonApiConfiguration _polygonApiConfiguration;

        public PolygonApiClientBuilder(PolygonApiConfiguration polygonApiConfiguration)
        {
            _polygonApiConfiguration = polygonApiConfiguration;
        }

        public PolygonApiClient BuildClient()
        {
            return new PolygonApiClient(_polygonApiConfiguration);
        }
    }
}
