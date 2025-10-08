static class BackEndpoints
{
    public static async Task<IResult> ShowHTML()
    {
        //grab this file from our filesystem 
        var html = await File.ReadAllTextAsync("index.html");
        //return that file to the browser
        return Results.Content(html, "text/html");
    }
}