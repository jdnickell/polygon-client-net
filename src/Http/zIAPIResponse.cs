namespace polygon_client_net.Http
{
    public interface zIAPIResponse<out T>
    {
        T? Body { get; }

        IResponse Response { get; }
    }
}
