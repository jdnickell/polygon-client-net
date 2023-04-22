namespace polygon_client_net.Models.Response;

public class TickerNewsResponse
{
    public string AmpUrl { get; set; } = default!;
    public string ArticleUrl { get; set; } = default!;
    public string Author { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Id { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public List<string> Keywords { get; set; } = default!;
    public DateTime PublishedUtc { get; set; } = default!;  
    public Publisher Publisher { get; set; } = default!;
    public List<string> Tickers { get; set; } = default!;   
    public string Title { get; set; } = default!;
}

public class Publisher
{
    public string FaviconUrl { get; set; } = default!;
    public string HomepageUrl { get; set; } = default!;
    public string LogoUrl { get; set; } = default!;
    public string Name { get; set; } = default!;
}
