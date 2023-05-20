using polygon_client_net.Clients;
using polygon_client_net.Http;
using polygon_client_net.Models.Request;

namespace polygon_client_net.Tests.Clients;

public class TickerClientTests
{
    private readonly string API_KEY = "YOUR_API_KEY";

    /// <summary>
    /// Temporary test - makes an actual request to the TickerDetails endpoint with the hard coded api key in <see cref="RequestParameters"/>
    /// </summary>
    [Fact]
    public async void GetTickerDetails_ValidRequest_ValidResponse()
    {
        var tickersRequest = new TickerDetailsRequest { Date = new DateOnly(2023, 4, 20) };
        var tickerDetailsResponseTask = new TickerClient(new ApiConnector(API_KEY)).GetTickerDetailsAsync("MSFT", tickersRequest);

        var result = await tickerDetailsResponseTask;

        // Then any result and any property deserialized correctly
        Assert.NotNull(result);
        Assert.Equal("MSFT", result.Results.Ticker);
    }

    [Fact]
    public async void GetTickers_ValidRequest_ValidResponse()
    {
        var tickersRequests = new List<TickersRequest>
        {
            // empty request object, returns all tickers
            new TickersRequest 
            { 
            },

            // search for a stock by name
            new TickersRequest 
            {
                Search = "brink"
            }

            // todo: test with order, limit, sort, type enums
        };

        foreach(var tickersRequest in tickersRequests)
        {
            var tickersResponseTask = new TickerClient(new ApiConnector(API_KEY)).GetTickersAsync(tickersRequest);

            var result = await tickersResponseTask;

            Assert.NotNull(result.Results.FirstOrDefault());
            Assert.NotNull(result.Results[0].Name);
        }
    }

    [Fact]
    public async void GetTickersPagingExample_ValidRequet_AllResultsPagedAndReturned()
    {
        // Arrange
        // empty request object, returns all tickers

        var pageSize = 1000;
        var tickersRequest = new TickersRequest
        {
            Limit = pageSize
        };
        var paginator = new Paginator();
        var apiConnector = new ApiConnector(API_KEY);
        var tickersResponseTask = new TickerClient(apiConnector).GetTickersPagedAsync(tickersRequest);
        var firstPage = await tickersResponseTask;

        // Act
        var allResults = await paginator.PaginateAll(firstPage, apiConnector);

        // Assert
        // There are results
        Assert.NotNull(allResults);

        // And more than a single page size of 1000 are present
        Assert.True(allResults.Count > pageSize);
    }
}
