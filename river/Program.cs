using System.Text;

async Task<IResult> HandlePost(HttpRequest request)
{
    using var reader = new StreamReader(request.Body, Encoding.UTF8);
    var body = await reader.ReadToEndAsync();
    Console.WriteLine(body);
    return Results.Ok();
}

async Task MSG_Get(string message)
{
    var httpClient = new HttpClient();
    var content = new StringContent(message, Encoding.UTF8, "application/json");
    await httpClient.PostAsync("http://localhost:3000/", content);
}

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//gets
app.MapGet("/", FrontEndEndpoints.ServeFrontEnd);
app.MapGet("/send-message/{message}", MSG_Get);

//posts
app.MapPost("/", HandlePost);


app.Run("http://localhost:3000");



