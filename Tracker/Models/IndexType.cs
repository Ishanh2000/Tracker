using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Tracker.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum IndexType
{
    Nifty50Index,
    NiftyNext50Index,
    Nifty100Index,
    NiftyMidCap150Index,
    Nifty200Index,
    NiftyLargeMidCap250Index,
    NiftySmallCap250Index,
    NiftyMidSmallCap400Index,
    Nifty500Index,
    Nifty500MultiCap502525Index,
    NiftyMicroCap250Index,
    NiftyTotalMarketIndex,
}
