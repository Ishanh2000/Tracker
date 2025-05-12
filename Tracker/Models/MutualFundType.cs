using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Tracker.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum MutualFundType
{
    DspSmallCapRegGrw,
    HdfcMidCapOpportunitiesRegGrw,
    IciciPrudentialBluechipRegGrw,
    IciciPrudentialMulticapRegGrw,
    KotakEmergingEquityRegGrw,
    MiraeAssetElssTaxSaverRegGrw,
    NipponIndiaMidCap150IndexDrcGrw,
    UtiNifty50IndexDrcGrw,
    UtiNiftyNext50IndexDrcGrw,
}
