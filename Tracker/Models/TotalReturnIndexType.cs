using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Tracker.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum TotalReturnIndexType
{
    Nifty50Tri,
    NiftyNext50Tri,
    Nifty100Tri,
    NiftyMidCap150Tri,
    Nifty200Tri,
    NiftyLargeMidCap250Tri,
    NiftySmallCap250Tri,
    NiftyMidSmallCap400Tri,
    Nifty500Tri,
    Nifty500MultiCap502525Tri,
    NiftyMicroCap250Tri,
    NiftyTotalMarketTri,
}
