using Microsoft.AspNetCore.Mvc;

namespace MockServer.Endpoints;

internal static class OpenApiEndpoints 
{
    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> ChatCompletions([FromBody] IEnumerable<Message> messages, 
                                                      string deploymentName)
    {
        return TypedResults.Ok();
    }
}