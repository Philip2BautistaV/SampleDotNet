var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "1st Test for Today");

app.Run();
