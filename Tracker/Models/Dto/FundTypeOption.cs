// AUM SHREEGANESHA-SHAARADAA-GURUBHYO NAMAH||
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tracker.Models.Dto;

public class FundTypeOption
{
    [JsonProperty("optionValue")]
    public FundType? OptionValue { get; set; }
    
    [JsonProperty("optionName")]
    public string? OptionName { get; set; }
}
