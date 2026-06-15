var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This test is brought to you by Accenture Philippines");

app.Run();
