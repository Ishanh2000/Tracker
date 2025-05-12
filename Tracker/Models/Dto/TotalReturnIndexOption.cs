// AUM SHREEGANESHA-SHAARADAA-GURUBHYO NAMAH||
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tracker.Models.Dto;

public class TotalReturnIndexOption
{
    [JsonProperty("optionValue")]
    public TotalReturnIndexType? OptionValue { get; set; }
    
    [JsonProperty("optionName")]
    public string? OptionName { get; set; }
}
