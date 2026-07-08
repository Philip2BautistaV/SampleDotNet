var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "For demonstration purposes");

app.Run();
