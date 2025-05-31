using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/", async (HttpRequest request) =>
{
    using var reader = new StreamReader(request.Body, Encoding.UTF8);
    var body = await reader.ReadToEndAsync();
    Console.WriteLine(body);
    return Results.Ok();
});

app.MapGet("/send-message/{message}", async (string message) =>
{
    var httpClient = new HttpClient();
    var content = new StringContent(message, Encoding.UTF8, "application/json");
    await httpClient.PostAsync("http://localhost:3000/", content);
});

app.Run("http://localhost:3000");



