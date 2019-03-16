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
  public class TflApiPresentationEntitiesRouteSequence {
    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Gets or Sets LineName
    /// </summary>
    [DataMember(Name="lineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineName")]
    public string LineName { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets IsOutboundOnly
    /// </summary>
    [DataMember(Name="isOutboundOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isOutboundOnly")]
    public bool? IsOutboundOnly { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets LineStrings
    /// </summary>
    [DataMember(Name="lineStrings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineStrings")]
    public List<string> LineStrings { get; set; }

    /// <summary>
    /// Gets or Sets Stations
    /// </summary>
    [DataMember(Name="stations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stations")]
    public List<TflApiPresentationEntitiesMatchedStop> Stations { get; set; }

    /// <summary>
    /// Gets or Sets StopPointSequences
    /// </summary>
    [DataMember(Name="stopPointSequences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopPointSequences")]
    public List<TflApiPresentationEntitiesStopPointSequence> StopPointSequences { get; set; }

    /// <summary>
    /// Gets or Sets OrderedLineRoutes
    /// </summary>
    [DataMember(Name="orderedLineRoutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderedLineRoutes")]
    public List<TflApiPresentationEntitiesOrderedRoute> OrderedLineRoutes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRouteSequence {\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  IsOutboundOnly: ").Append(IsOutboundOnly).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  LineStrings: ").Append(LineStrings).Append("\n");
      sb.Append("  Stations: ").Append(Stations).Append("\n");
      sb.Append("  StopPointSequences: ").Append(StopPointSequences).Append("\n");
      sb.Append("  OrderedLineRoutes: ").Append(OrderedLineRoutes).Append("\n");
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
