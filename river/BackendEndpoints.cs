// this again is a static class being used as a named holder for the ReceiveMessage function

static class BackendEndpoints
{
    public static async Task<IResult> ReceiveMessage(Message message)
    {
        //write the text to the console
        Console.WriteLine(message.Text);
        //return this content to the sender (our frontend)
        //if you look inside the network tools for this you can see this message.
        return Results.Content("message received", "text/html");
    }
}



//keeping all of the message information together incase we want to add more data to a message, like the user, ect
class Message
{
    //public (meaning it can be accessed by anyone)
    //string (meaning its data type)
    //Text (meaning the name of the property)
    //{ get; set; } (the functions this property can hold when you get or set to this field. the current syntax means do nothing)
    //= ""; (a default value incase none is provided. the default value being an empty string)

    public string Text { get; set; } = "";
}