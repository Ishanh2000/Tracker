using Newtonsoft.Json;

namespace Tracker.Models.Dao;

public class MutualFundMetadata
{
    [JsonProperty("id")]
    public MutualFundType? Id { get; set; }

    [JsonProperty("fundHouse")]
    public string? FundHouse { get; set; }

    [JsonProperty("fundName")]
    public string? FundName { get; set; }

    [JsonProperty("plan")]
    public string? Plan { get; set; }

    [JsonProperty("mode")]
    public string? Mode { get; set; }

    [JsonProperty("isin")]
    public string? Isin { get; set; }

    [JsonProperty("internalFundCode")]
    public string? InternalFundCode { get; set; }

    [JsonProperty("originalBenchmarkTri")]
    public TotalReturnIndexType? OriginalBenchmarkTri { get; set; }

    [JsonProperty("navHistoryUrl")]
    public string? NavHistoryUrl { get; set; }
}
