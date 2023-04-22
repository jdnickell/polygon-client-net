namespace polygon_client_net.Models;

public interface IPaginatable<T>
{
    string? NextUrl { get; set; }

    List<T>? Results { get; set; }
}

public interface IPaginatable<T, TNext>
{
    string? NextUrl { get; set; }

    List<T>? Results { get; set; }
}
