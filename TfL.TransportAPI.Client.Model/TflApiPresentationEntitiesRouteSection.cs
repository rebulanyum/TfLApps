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
  public class TflApiPresentationEntitiesRouteSection {
    /// <summary>
    /// The Id of the route
    /// </summary>
    /// <value>The Id of the route</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The Id of the Line
    /// </summary>
    /// <value>The Id of the Line</value>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// The route code
    /// </summary>
    /// <value>The route code</value>
    [DataMember(Name="routeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeCode")]
    public string RouteCode { get; set; }

    /// <summary>
    /// Name such as \"72\"
    /// </summary>
    /// <value>Name such as \"72\"</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The co-ordinates of the route's path as a geoJSON lineString
    /// </summary>
    /// <value>The co-ordinates of the route's path as a geoJSON lineString</value>
    [DataMember(Name="lineString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineString")]
    public string LineString { get; set; }

    /// <summary>
    /// Inbound or Outbound
    /// </summary>
    /// <value>Inbound or Outbound</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// The name of the Origin StopPoint
    /// </summary>
    /// <value>The name of the Origin StopPoint</value>
    [DataMember(Name="originationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originationName")]
    public string OriginationName { get; set; }

    /// <summary>
    /// The name of the Destination StopPoint
    /// </summary>
    /// <value>The name of the Destination StopPoint</value>
    [DataMember(Name="destinationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationName")]
    public string DestinationName { get; set; }

    /// <summary>
    /// The DateTime that the Service containing this Route is valid until.
    /// </summary>
    /// <value>The DateTime that the Service containing this Route is valid until.</value>
    [DataMember(Name="validTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validTo")]
    public DateTime? ValidTo { get; set; }

    /// <summary>
    /// The DateTime that the Service containing this Route is valid from.
    /// </summary>
    /// <value>The DateTime that the Service containing this Route is valid from.</value>
    [DataMember(Name="validFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFrom")]
    public DateTime? ValidFrom { get; set; }

    /// <summary>
    /// Gets or Sets RouteSectionNaptanEntrySequence
    /// </summary>
    [DataMember(Name="routeSectionNaptanEntrySequence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeSectionNaptanEntrySequence")]
    public List<TflApiPresentationEntitiesRouteSectionNaptanEntrySequence> RouteSectionNaptanEntrySequence { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRouteSection {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  RouteCode: ").Append(RouteCode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LineString: ").Append(LineString).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  OriginationName: ").Append(OriginationName).Append("\n");
      sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
      sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
      sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
      sb.Append("  RouteSectionNaptanEntrySequence: ").Append(RouteSectionNaptanEntrySequence).Append("\n");
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
