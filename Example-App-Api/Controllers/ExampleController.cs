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
        var result = await client.Ticker.GetTickersAsync(new TickersRequest 
            { 
                IsActive = true,
                MarketType = MarketType.Stocks,
                Type = TickerType.CS,
                Limit = 10,
                Search = "Bri"
            }
        );
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
    public async Task<IActionResult> GetTickersPagedAsync(string? cursor, int? limit)
    {
        // the polygon tickers api supports less than / greater than filter params. That's probably better for creating a list control that loads results as you scroll.
        // This cursor approach allows a use case where a request's purpose is to load all items, but provides a user control over continuing or cancelling the operation.
        var tickersRequest = new TickersRequest
        {
            IsActive = true,
            Limit = 1000,
            MarketType = MarketType.Stocks,
            Type = TickerType.CS
        };

        if (!string.IsNullOrWhiteSpace(cursor))
        {
            tickersRequest.Cursor = cursor;
            tickersRequest.Limit = limit.HasValue ? limit : 1000;
        }

        var client = _polygonApiClientBuilder.BuildClient();
        var page = await client.Ticker.GetTickersAsync(tickersRequest);

        return Ok(page);
    }

    [HttpGet]
    [Route("[action]", Name = "GetStockFinancials")]
    public async Task<IActionResult> GetStockFinancials(string ticker)
    {
        var pageSize = 100;
        var stockFinancialsRequest = new StockFinancialsRequest
        {
            Limit = 1, // get the most recent period of the report
            Ticker = ticker.ToUpper(),
            Timeframe = Timeframe.Annual,
            IncludeSources = true,
            PeriodOfReportDate = new DateOnly(2021, 01, 01),
            Sort = "period_of_report_date"
        };

        var client = _polygonApiClientBuilder.BuildClient();
        var stockFinancialsResponseTask = client.StockFinancialsClient.GetStockFinancialsAsync(stockFinancialsRequest);
        var firstPage = await stockFinancialsResponseTask;
        var result = await client.PaginateAll(firstPage);
        return Ok(result);
    }
}
