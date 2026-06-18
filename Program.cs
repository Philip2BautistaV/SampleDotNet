var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "1st testing for Orchastration in DataPlatform");

app.Run();
