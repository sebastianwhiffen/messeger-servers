static class BackendEndpoints
{
    public static async Task<IResult> ReceiveMessage(Message message)
    {
        Console.WriteLine(message.Text);
        return Results.Content("message received", "text/html");
    }
}


class Message
{
    public string Text { get; set; } = "";
}