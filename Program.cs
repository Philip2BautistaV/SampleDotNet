var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "121212121212121212");

app.Run();
