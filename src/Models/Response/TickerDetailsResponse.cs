namespace polygon_client_net.Models.Response;

public class TickerDetailsResponse
{
    public bool Active { get; set; }
    public Address Address { get; set; } = default!;
    public Branding Branding { get; set; } = default!;
    public string Cik { get; set; } = default!;
    public string CompositeFigi { get; set; } = default!;
    public string CurrencyName { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string HomepageUrl { get; set; } = default!;
    public string ListDate { get; set; } = default!;
    public string Locale { get; set; } = default!;
    public string Market { get; set; } = default!;
    public long MarketCap { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string PrimaryExchange { get; set; } = default!;
    public int RoundLot { get; set; } = default!;
    public string ShareClassFigi { get; set; } = default!;
    public long ShareClassSharesOutstanding { get; set; } = default!;
    public string SicCode { get; set; } = default!;
    public string SicDescription { get; set; } = default!;
    public string Ticker { get; set; } = default!;
    public string TickerRoot { get; set; } = default!;
    public int TotalEmployees { get; set; } = default!;
    public string Type { get; set; } = default!;
    public long WeightedSharesOutstanding { get; set; } = default!;
}

public class Address
{
    public string Address1 { get; set; } = default!;
    public string City { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public string State { get; set; } = default!;
}

public class Branding
{
    public string IconUrl { get; set; } = default!;
    public string LogoUrl { get; set; } = default!;
}
