var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "I love you Khrisca and Kaiden");

app.Run();
