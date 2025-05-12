using Newtonsoft.Json;

namespace Tracker.Models.Dao;

public class IndexMetadata
{
    [JsonProperty("indexType")]
    public IndexType? IndexType { get; set; }

    [JsonProperty("indexName")]
    public string? IndexName { get; set; }

    [JsonProperty("methodology")]
    public string? Methodology { get; set; }

    [JsonProperty("numConstituents")]
    public int? NumberOfConstituents { get; set; }

    [JsonProperty("launchDate")]
    public string? LaunchDate { get; set; }

    [JsonProperty("baseDate")]
    public string? BaseDate { get; set; }

    [JsonProperty("baseValue")]
    public double? BaseValue { get; set; }

    [JsonProperty("calculationFrequency")]
    public string? CalculationFrequency { get; set; }

    [JsonProperty("indexRebalancing")]
    public string? IndexRebalancing { get; set; }
}
