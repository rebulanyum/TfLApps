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
  public class TflApiPresentationEntitiesStopPointRouteSection {
    /// <summary>
    /// Gets or Sets NaptanId
    /// </summary>
    [DataMember(Name="naptanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanId")]
    public string NaptanId { get; set; }

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets ValidFrom
    /// </summary>
    [DataMember(Name="validFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFrom")]
    public DateTime? ValidFrom { get; set; }

    /// <summary>
    /// Gets or Sets ValidTo
    /// </summary>
    [DataMember(Name="validTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validTo")]
    public DateTime? ValidTo { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets RouteSectionName
    /// </summary>
    [DataMember(Name="routeSectionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeSectionName")]
    public string RouteSectionName { get; set; }

    /// <summary>
    /// Gets or Sets LineString
    /// </summary>
    [DataMember(Name="lineString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineString")]
    public string LineString { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="isActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="serviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceType")]
    public string ServiceType { get; set; }

    /// <summary>
    /// Gets or Sets VehicleDestinationText
    /// </summary>
    [DataMember(Name="vehicleDestinationText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vehicleDestinationText")]
    public string VehicleDestinationText { get; set; }

    /// <summary>
    /// Gets or Sets DestinationName
    /// </summary>
    [DataMember(Name="destinationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationName")]
    public string DestinationName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStopPointRouteSection {\n");
      sb.Append("  NaptanId: ").Append(NaptanId).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
      sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  RouteSectionName: ").Append(RouteSectionName).Append("\n");
      sb.Append("  LineString: ").Append(LineString).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  VehicleDestinationText: ").Append(VehicleDestinationText).Append("\n");
      sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
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
