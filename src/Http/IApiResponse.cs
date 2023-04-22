namespace polygon_client_net.Http
{
    public interface IApiResponse<out T>
    {
        T? Body { get; }

        IResponse Response { get; }
    }
}
