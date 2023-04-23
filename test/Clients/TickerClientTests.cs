using polygon_client_net.Clients;
using polygon_client_net.Http;
using polygon_client_net.Models.Request;

namespace polygon_client_net.Tests.Clients;

public class TickerClientTests
{
    /// <summary>
    /// Temporary test - makes an actual request to the TickerDetails endpoint with the hard coded api key in <see cref="RequestParameters"/>
    /// </summary>
    [Fact]
    public async void GetTickerDetails_ValidRequest_ValidResponse()
    {
        var tickersRequest = new TickerDetailsRequest { Date = new DateOnly(2023, 4, 20) };
        var tickerDetailsResponseTask = new TickerClient(new ApiConnector()).GetTickerDetailsAsync("GME", tickersRequest);

        var result = await tickerDetailsResponseTask;

        Assert.NotNull(result);
    }
}
