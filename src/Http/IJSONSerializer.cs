namespace polygon_client_net.Http
{
    internal interface IJSONSerializer
    {
        void SerializeRequest(IRequest request);
        IAPIResponse<T> DeserializeResponse<T>(IResponse response);
    }
}
