var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This code is for Production - 06/17/2026");

app.Run();
