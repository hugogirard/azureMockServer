namespace MockServer.Endpoints;

internal static class OpenApiMap 
{
    public static IEndpointRouteBuilder MapOpenApi(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/", () => new { message = "OpenAI Mock service is running." });
        builder.MapPost("/openai/deployments/{deploymentName}/chat/completions", OpenApiEndpoints.ChatCompletions);

        return builder;
    }
}