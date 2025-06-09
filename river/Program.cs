
// the web application builder is a factory class (https://refactoring.guru/design-patterns/factory-method)
// it's main purpose is to expose methods which instantiate a web application builder.
// a web application builder is not a web application yet. meaning at this point in the code it is not running. 
// the web application builder presents you with an interface in which you can use to build and configure a web application before calling app.Run()
var builder = WebApplication.CreateBuilder(args);

// after building it into an app we can now specify some more details about how it will behave. and inevitably call app.Run()
var app = builder.Build();


//here we use the MapGet() function
//parameter one is a string and is used to define what address this function will be triggered on.
//parameter two is the function we would like to call when this address is hit
//the first one will be triggered on http GET requests.
app.MapGet("/", FrontendEndpoints.ServeFrontEnd);

//the second one will be triggered on http POST requests.
app.MapPost("/receive-message", BackendEndpoints.ReceiveMessage);

//call app.Run to start the app at an address
app.Run("http://localhost:3000");



