var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AIML");

app.Run();
