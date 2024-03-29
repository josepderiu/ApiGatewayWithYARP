var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/bar", () => "Hello from bar!");

app.Run();
