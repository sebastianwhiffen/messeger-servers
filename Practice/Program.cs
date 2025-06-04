using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async Task<IResult> HandlePost(HttpRequest request)
{
    
}
app.MapGet("/", HandlePost);


app.Run("http://localhost:3000");