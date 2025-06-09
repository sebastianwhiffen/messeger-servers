//this is a STATIC class. it means I do not have to call the 'new' keyword to access the methods inside of it.
//I only need to call FrontendEndpoints.ServeFrontEnd()
//as you will be able to see inside Program.cs

static class FrontendEndpoints
{
    public static async Task<IResult> ServeFrontEnd()
    {
        //grab this file from our filesystem 
        var html = await File.ReadAllTextAsync("index.html");
        //return that file to the browser
        return Results.Content(html, "text/html");
    }
}