using System.Text;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/foo", (HttpRequest request, ILogger<Program> logger) =>
{
    StringBuilder requestData = new();

    foreach (var header in request.Headers)
    {
        requestData.AppendLine($"\t{header.Key}: {header.Value}");
    }

    foreach (var query in request.Query)
    {
        requestData.AppendLine($"\t{query.Key}: {query.Value}");
    }

    logger.LogInformation("Request data:\n{RequestData}", requestData.ToString());
});

app.MapPost("/sayhello", (SayHelloRequest request, ILogger<Program> logger) =>
{
    logger.LogInformation("hello {Name} from body method", request.Name);
});

app.MapPost("/sayhelloqueryparams", (string name, ILogger<Program> logger) =>
{
    logger.LogInformation("hello {name} from query params method", name);
});

app.Run();

public sealed record SayHelloRequest(string Name);