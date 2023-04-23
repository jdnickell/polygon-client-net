namespace polygon_client_net.Models.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class QueryParameterAttribute : Attribute
{
    public string Key { get; }

    public QueryParameterAttribute(string key)
    {
        Key = key;
    }
}
