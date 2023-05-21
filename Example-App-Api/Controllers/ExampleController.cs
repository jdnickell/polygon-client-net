using Microsoft.AspNetCore.Mvc;
using polygon_client_net.Clients;
using polygon_client_net.Models.Request;

namespace Example_App_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly PolygonApiClientBuilder _polygonApiClientBuilder;

    public ExampleController(PolygonApiClientBuilder polygonApiClientBuilder)
    {
        _polygonApiClientBuilder = polygonApiClientBuilder;
    }

    [HttpGet]
    [Route("[action]", Name = "GetTickers")]
    public async Task<IActionResult> GetTickersAsync()
    {
        var client = _polygonApiClientBuilder.BuildClient();
        var result = await client.Ticker.GetTickersAsync(new TickersRequest { Search = "brink" });
        return Ok(result);
    }

    [HttpGet]
    [Route("[action]", Name = "GetTickerDetails")]
    public async Task<IActionResult> GetTickerDetailsAsync()
    {
        var client = _polygonApiClientBuilder.BuildClient();
        var tickersRequest = new TickerDetailsRequest { Date = new DateOnly(2023, 4, 20) };
        var result = await client.Ticker.GetTickerDetailsAsync("MSFT", tickersRequest);

        return Ok(result);
    }

    [HttpGet]
    [Route("[action]", Name = "GetTickersPaged")]
    public async Task<IActionResult> GetTickersPagedAsync()
    {
        var pageSize = 1000;
        var tickersRequest = new TickersRequest
        {
            Limit = pageSize
        };

        var client = _polygonApiClientBuilder.BuildClient();

        var tickersResponseTask = client.Ticker.GetTickersPagedAsync(tickersRequest);
        var firstPage = await tickersResponseTask;

        var result = await client.PaginateAll(firstPage);

        return Ok(result.Take(300));
    }
}
