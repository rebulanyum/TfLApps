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
  public class TflApiPresentationEntitiesCycleSuperhighway {
    /// <summary>
    /// The Id
    /// </summary>
    /// <value>The Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The long label to show on maps when zoomed in
    /// </summary>
    /// <value>The long label to show on maps when zoomed in</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// The short label to show on maps
    /// </summary>
    /// <value>The short label to show on maps</value>
    [DataMember(Name="labelShort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelShort")]
    public string LabelShort { get; set; }

    /// <summary>
    /// A LineString or MultiLineString that forms the route of the highway
    /// </summary>
    /// <value>A LineString or MultiLineString that forms the route of the highway</value>
    [DataMember(Name="geography", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geography")]
    public SystemDataSpatialDbGeography Geography { get; set; }

    /// <summary>
    /// True if the route is split into segments
    /// </summary>
    /// <value>True if the route is split into segments</value>
    [DataMember(Name="segmented", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segmented")]
    public bool? Segmented { get; set; }

    /// <summary>
    /// When the data was last updated
    /// </summary>
    /// <value>When the data was last updated</value>
    [DataMember(Name="modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified")]
    public DateTime? Modified { get; set; }

    /// <summary>
    /// Cycle route status i.e Proposed, Existing etc
    /// </summary>
    /// <value>Cycle route status i.e Proposed, Existing etc</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Type of cycle route e.g CycleSuperhighways, Quietways, MiniHollands etc
    /// </summary>
    /// <value>Type of cycle route e.g CycleSuperhighways, Quietways, MiniHollands etc</value>
    [DataMember(Name="routeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeType")]
    public string RouteType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesCycleSuperhighway {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  LabelShort: ").Append(LabelShort).Append("\n");
      sb.Append("  Geography: ").Append(Geography).Append("\n");
      sb.Append("  Segmented: ").Append(Segmented).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  RouteType: ").Append(RouteType).Append("\n");
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
