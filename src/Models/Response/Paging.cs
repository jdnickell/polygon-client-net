namespace polygon_client_net.Models.Response;

public class Paging<T> : IPaginatable<T>
{
    public int? Count { get; set; } = default!;
    public string? NextUrl { get; set; } = default!;
    public string? RequestId { get; set; } = default!;
    public List<T>? Results { get; set; } = default!;
    public string? Status { get; set; } = default!;
}
