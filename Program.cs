var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Happy Anniversary to Pretty Wife Khrisca");

app.Run();
