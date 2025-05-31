using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async Task<IResult> HandlePost(HttpRequest request)
{
    using var reader = new StreamReader(request.Body, Encoding.UTF8);
    var body = await reader.ReadToEndAsync();
    Console.WriteLine(body);
    return Results.Ok();
}
app.MapPost("/", HandlePost);

async Task MSG_Get(string message)
{
    var httpClient = new HttpClient();
    var content = new StringContent(message, Encoding.UTF8, "application/json");
    await httpClient.PostAsync("http://localhost:3000/", content);
}
app.MapGet("/send-message/{message}", MSG_Get);


app.Run("http://localhost:3000");



