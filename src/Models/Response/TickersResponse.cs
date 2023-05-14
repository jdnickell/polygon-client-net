﻿namespace polygon_client_net.Models.Response;

public class TickersResponse
{
    public int Count { get; set; } = default!;
    public string NextUrl { get; set; } = default!;
    public string RequestId { get; set; } = default!;
    public Result[] Results { get; set; } = Array.Empty<Result>();
    public string Status { get; set; } = default!;
}

public class Result
{
    public bool Active { get; set; } = default!;
    public string Cik { get; set; } = default!;
    public string CompositeFigi { get; set; } = default!;
    public string CurrencyName { get; set; } = default!;
    public DateTime LastUpdatedUtc { get; set; }
    public string Locale { get; set; } = default!;
    public string Market { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string PrimaryExchange { get; set; } = default!;
    public string ShareClassFigi { get; set; } = default!;
    public string Ticker { get; set; } = default!;
    public string Type { get; set; } = default!;
}
