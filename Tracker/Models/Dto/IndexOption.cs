// AUM SHREEGANESHA-SHAARADAA-GURUBHYO NAMAH||
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tracker.Models.Dto;

public class IndexOption
{
    [JsonProperty("optionValue")]
    public IndexType? OptionValue { get; set; }
    
    [JsonProperty("optionName")]
    public string? OptionName { get; set; }
}
