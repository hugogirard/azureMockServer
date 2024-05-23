using System.Text.Json.Serialization;

namespace MockServer.Models;

public record Message(string Role, Content Content);

public record Content(Simulation Simulation);

public record Simulation(Default Default);

public record Default
{
    [JsonPropertyName("response_status_code")]
    public required int ResponseStatusCode { get; set; }

    [JsonPropertyName("wait_time_ms")]
    public required int WaitTimeMs { get; set; }
}