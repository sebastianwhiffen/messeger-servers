static class FrontendEndpoints
{
    public static async Task<IResult> ServeFrontEnd()
    {
        var html = await File.ReadAllTextAsync("index.html");
        return Results.Content(html, "text/html");
    }
}