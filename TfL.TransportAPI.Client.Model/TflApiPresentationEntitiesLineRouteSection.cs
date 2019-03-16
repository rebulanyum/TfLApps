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
  public class TflApiPresentationEntitiesLineRouteSection {
    /// <summary>
    /// Gets or Sets RouteId
    /// </summary>
    [DataMember(Name="routeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeId")]
    public int? RouteId { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets FromStation
    /// </summary>
    [DataMember(Name="fromStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromStation")]
    public string FromStation { get; set; }

    /// <summary>
    /// Gets or Sets ToStation
    /// </summary>
    [DataMember(Name="toStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toStation")]
    public string ToStation { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLineRouteSection {\n");
      sb.Append("  RouteId: ").Append(RouteId).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  FromStation: ").Append(FromStation).Append("\n");
      sb.Append("  ToStation: ").Append(ToStation).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  VehicleDestinationText: ").Append(VehicleDestinationText).Append("\n");
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
