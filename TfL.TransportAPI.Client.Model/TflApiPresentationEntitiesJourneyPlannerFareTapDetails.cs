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
  public class TflApiPresentationEntitiesJourneyPlannerFareTapDetails {
    /// <summary>
    /// Gets or Sets ModeType
    /// </summary>
    [DataMember(Name="modeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeType")]
    public string ModeType { get; set; }

    /// <summary>
    /// Gets or Sets ValidationType
    /// </summary>
    [DataMember(Name="validationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationType")]
    public string ValidationType { get; set; }

    /// <summary>
    /// Gets or Sets HostDeviceType
    /// </summary>
    [DataMember(Name="hostDeviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostDeviceType")]
    public string HostDeviceType { get; set; }

    /// <summary>
    /// Gets or Sets BusRouteId
    /// </summary>
    [DataMember(Name="busRouteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "busRouteId")]
    public string BusRouteId { get; set; }

    /// <summary>
    /// Gets or Sets NationalLocationCode
    /// </summary>
    [DataMember(Name="nationalLocationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nationalLocationCode")]
    public int? NationalLocationCode { get; set; }

    /// <summary>
    /// Gets or Sets TapTimestamp
    /// </summary>
    [DataMember(Name="tapTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tapTimestamp")]
    public DateTime? TapTimestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerFareTapDetails {\n");
      sb.Append("  ModeType: ").Append(ModeType).Append("\n");
      sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
      sb.Append("  HostDeviceType: ").Append(HostDeviceType).Append("\n");
      sb.Append("  BusRouteId: ").Append(BusRouteId).Append("\n");
      sb.Append("  NationalLocationCode: ").Append(NationalLocationCode).Append("\n");
      sb.Append("  TapTimestamp: ").Append(TapTimestamp).Append("\n");
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
