var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hi Kaiden and Khrisca.  This is Alexa at your service");

app.Run();
