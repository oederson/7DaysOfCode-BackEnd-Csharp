using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp.Models;

public partial class ListaPokemon
{

    [JsonPropertyName("count")]
    public long Count { get; set; }

    [JsonPropertyName("next")]
    public Uri Next { get; set; }

    [JsonPropertyName("previous")]
    public object Previous { get; set; }

    [JsonPropertyName("results")]
    public Result[] Results { get; set; }
}

public partial class Result
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }
}
