namespace polygon_client_net.Http
{
    public interface IAPIResponse<out T>
    {
        T? Body { get; }

        IResponse Response { get; }
    }
}
