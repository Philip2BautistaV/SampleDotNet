var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Production Environment - 06/17/2026");

app.Run();
