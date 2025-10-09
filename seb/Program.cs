var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

//code taken from: https://stackoverflow.com/questions/48285408/how-to-disable-cors-completely-in-webapi
//bc we dont care about CORS for now :)
app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true));

var users = new[]
{
    "river", "seb"
};


app.MapGet("/get-users", () => { return users; });

app.Run("http://localhost:3000");


