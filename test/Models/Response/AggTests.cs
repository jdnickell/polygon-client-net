using polygon_client_net.Models.Response;
using System.Text.Json;

namespace polygon_client_net.Tests.Models.Response;

public class AggTests
{
    [Fact]
    public void FromDictionary_ValidJson_DeserializedSuccessfully()
    {
        // Arrange
        var exampleResponseJson = "{\"v\": 70790813,\"vw\": 131.6292,\"o\": 130.465,\"c\": 130.15,\"h\": 133.41,\"l\": 129.89,\"t\": 1673240400000,\"n\": 645365}";
        var exampleResponseJsonDeserialized = JsonSerializer.Deserialize<Dictionary<string, object>>(exampleResponseJson);

        var expectedResult = new Agg
        {
            Close = (float?)130.15,
            High = (float?)133.41,
            Low = (float?)129.89,
            Open = (float?)130.465,
            Otc = null,
            Timestamp = DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64("1673240400000")),
            Transactions = 645365,
            Volume = 70790813,
            Vwap = (float?)131.6292
        };

        // Act
        var agg = Agg.FromDictionary(exampleResponseJsonDeserialized);

        // Assert
        Assert.Equivalent(expectedResult, agg);
    }
}
