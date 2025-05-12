using Newtonsoft.Json;

namespace Tracker.Models.Dao;

public class TotalReturnIndexMetadata
{
    [JsonProperty("triType")]
    public TotalReturnIndexType? TotalReturnIndexType { get; set; }

    [JsonProperty("triName")]
    public string? TotalReturnIndexName { get; set; }

    [JsonProperty("baseIndexType")]
    public IndexType? BaseIndexType { get; set; }
}
