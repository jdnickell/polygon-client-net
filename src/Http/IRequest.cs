﻿namespace polygon_client_net.Http
{
    public interface IRequest
    {
        Uri BaseAddress { get; }

        Uri Endpoint { get; }

        IDictionary<string, string> Headers { get; }

        IDictionary<string, string> Parameters { get; }

        HttpMethod Method { get; }

        object? Body { get; set; }
    }
}
