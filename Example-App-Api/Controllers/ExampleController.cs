using Microsoft.AspNetCore.Mvc;
using polygon_client_net.Clients;

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
    public async Task<IActionResult> Get()
    {
        var client = _polygonApiClientBuilder.BuildClient();
        var result = await client.Ticker.GetTickersAsync(new polygon_client_net.Models.Request.TickersRequest { Search = "brink" });
        return Ok(result);
    }
}
