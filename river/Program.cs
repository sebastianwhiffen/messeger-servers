var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is Rivers server, Welcome");
app.MapGet("/1", () => "OK");

app.Run();
