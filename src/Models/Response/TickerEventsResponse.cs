namespace polygon_client_net.Models.Response;

public class TickerEventsResponse
{
    public Event[] Events { get; set; } = Array.Empty<Event>();
    public string Name { get; set; } = default!;
}

public class Event
{
    public string Date { get; set; } = default!;
    public TickerChange TickerChange { get; set; } = default!;
    public string Type { get; set; } = default!;
}

public class TickerChange
{
    public string Ticker { get; set; } = default!;
}
