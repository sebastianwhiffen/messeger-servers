using System.Text;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", FrontendEndpoints.ServeFrontEnd);

//posts
app.MapPost("/receive-message", BackendEndpoints.ReceiveMessage);


app.Run("http://localhost:3000");



