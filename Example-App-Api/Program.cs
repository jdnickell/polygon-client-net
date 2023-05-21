using Microsoft.Extensions.DependencyInjection.Extensions;
using polygon_client_net.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Example implementing a custom paginator
// builder.Services.TryAddSingleton(new PolygonApiConfiguration("YOUR_POLYGON_API_KEY", new CustomPaginator()));

// Use the default paginator
builder.Services.TryAddSingleton(new PolygonApiConfiguration("YOUR_POLYGON_API_KEY"));

builder.Services.TryAddScoped<PolygonApiClientBuilder>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
