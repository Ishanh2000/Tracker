using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Tracker.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum FundType
{
    Index,
    
    TotalReturnIndex,
    
    Stock,

    MutualFund,

    Insurance,
}
