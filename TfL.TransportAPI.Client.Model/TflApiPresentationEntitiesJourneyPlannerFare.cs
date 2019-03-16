using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesJourneyPlannerFare {
    /// <summary>
    /// Gets or Sets LowZone
    /// </summary>
    [DataMember(Name="lowZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowZone")]
    public int? LowZone { get; set; }

    /// <summary>
    /// Gets or Sets HighZone
    /// </summary>
    [DataMember(Name="highZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highZone")]
    public int? HighZone { get; set; }

    /// <summary>
    /// Gets or Sets Cost
    /// </summary>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public int? Cost { get; set; }

    /// <summary>
    /// Gets or Sets ChargeProfileName
    /// </summary>
    [DataMember(Name="chargeProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeProfileName")]
    public string ChargeProfileName { get; set; }

    /// <summary>
    /// Gets or Sets IsHopperFare
    /// </summary>
    [DataMember(Name="isHopperFare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isHopperFare")]
    public bool? IsHopperFare { get; set; }

    /// <summary>
    /// Gets or Sets ChargeLevel
    /// </summary>
    [DataMember(Name="chargeLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeLevel")]
    public string ChargeLevel { get; set; }

    /// <summary>
    /// Gets or Sets Peak
    /// </summary>
    [DataMember(Name="peak", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "peak")]
    public int? Peak { get; set; }

    /// <summary>
    /// Gets or Sets OffPeak
    /// </summary>
    [DataMember(Name="offPeak", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offPeak")]
    public int? OffPeak { get; set; }

    /// <summary>
    /// Gets or Sets Taps
    /// </summary>
    [DataMember(Name="taps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taps")]
    public List<TflApiPresentationEntitiesJourneyPlannerFareTap> Taps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerFare {\n");
      sb.Append("  LowZone: ").Append(LowZone).Append("\n");
      sb.Append("  HighZone: ").Append(HighZone).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  ChargeProfileName: ").Append(ChargeProfileName).Append("\n");
      sb.Append("  IsHopperFare: ").Append(IsHopperFare).Append("\n");
      sb.Append("  ChargeLevel: ").Append(ChargeLevel).Append("\n");
      sb.Append("  Peak: ").Append(Peak).Append("\n");
      sb.Append("  OffPeak: ").Append(OffPeak).Append("\n");
      sb.Append("  Taps: ").Append(Taps).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
