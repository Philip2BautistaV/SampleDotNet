var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "I Love my Family!");

app.Run();
