// AUM SHREEGANESHA-SHAARADAA-GURUBHYO NAMAH||
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tracker.Models.Dto;

public class MutualFundOption
{
    [JsonProperty("optionValue")]
    public MutualFundType? OptionValue { get; set; }
    
    [JsonProperty("optionName")]
    public string? OptionName { get; set; }
}
