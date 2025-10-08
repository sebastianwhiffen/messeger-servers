var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var users = new[]
{
    "river", "seb"
};

string myVariable = "Hello, World!";

app.MapGet("/usrlst", BackEndpoints.ShowHTML);
app.MapGet("/get-users", () => { return users; });
app.Run();

