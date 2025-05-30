var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is Rivers server, Welcome");


app.Run("http://localhost:3000");
