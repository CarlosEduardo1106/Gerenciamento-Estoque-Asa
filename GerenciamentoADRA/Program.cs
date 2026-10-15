using Microsoft.EntityFrameworkCore;
using GerenciamentoADRA.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<AdraContext>(options => options.UseMySql(ConnectionString,
        ServerVersion.AutoDetect(ConnectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/Categorias", async (AdraContext db) =>
{
   var categorias = await db.Categorias.ToListAsync();
   return Results.Ok(categorias);
});

app.MapGet("/Produtos", async (AdraContext db) =>
{
   var produtos = await db.Produtos.ToListAsync();
   return Results.Ok(produtos); 
});

app.MapGet("/Movimentacoes", async (AdraContext db) =>
{
   var movimentacoes = await db.Movimentacoes.ToListAsync();
   return Results.Ok(movimentacoes); 
});

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
