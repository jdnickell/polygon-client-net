namespace polygon_client_net.Http
{
    internal interface IJsonSerializer
    {
        void SerializeRequest(IRequest request);
        IApiResponse<T> DeserializeResponse<T>(IResponse response);
    }
}
