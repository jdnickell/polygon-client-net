namespace polygon_client_net.Http
{
    internal interface zIJSONSerializer
    {
        void SerializeRequest(IRequest request);
        zIAPIResponse<T> DeserializeResponse<T>(IResponse response);
    }
}
