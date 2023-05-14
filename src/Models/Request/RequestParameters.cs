using polygon_client_net.Models.Attributes;
using System.Reflection;

namespace polygon_client_net.Models.Request;

public abstract class RequestParameters
{
    /// <summary>
    /// One authentication option is to append the apikey query parameter to all requests, another option is a Bearer token auth header
    /// TODO: DI magic from caller, or use headers instead
    /// </summary>
    private static string API_KEY => "YtNBqUAKSTLS1sspFlIpYpUcxNR2vfBp";

    public Dictionary<string, string> BuildQueryParams()
    {
        var queryParameters = new Dictionary<string, string>();
        var type = GetType();
        var queryProperties = GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
            .Where(property => property.GetCustomAttributes(typeof(QueryParameterAttribute), true).Length > 0);

        foreach (var queryPropertyInfo in queryProperties)
        {
            var attribute = queryPropertyInfo.GetCustomAttribute<QueryParameterAttribute>();
            if (attribute != null)
            {
                AddQueryParameters(queryParameters, queryPropertyInfo, attribute);
            }
        }

        queryParameters.Add("apiKey", API_KEY);

        return queryParameters;
    }

    private void AddQueryParameters(Dictionary<string, string> queryParameters, PropertyInfo queryPropertyInfo, QueryParameterAttribute attribute)
    {
        object? value = queryPropertyInfo.GetValue(this);
        if (value != null)
        {
            if (value is bool valueAsBool)
            {
                queryParameters.Add(attribute.Key ?? queryPropertyInfo.Name, valueAsBool ? "true" : "false");
            }
            else
            {
                queryParameters.Add(attribute.Key ?? queryPropertyInfo.Name, value.ToString()); // TODO: Custom exception
            }
            // TODO: handle enum, lists, other?
        }
    }
}
