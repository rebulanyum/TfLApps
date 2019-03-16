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
  public class TflApiPresentationEntitiesStreet {
    /// <summary>
    /// Street name
    /// </summary>
    /// <value>Street name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Type of road closure. Some example values:              Open = road is open, not blocked, not closed, not restricted. It maybe that the disruption has been moved out of the carriageway.              Partial Closure = road is partially blocked, closed or restricted.               Full Closure = road is fully blocked or closed.
    /// </summary>
    /// <value>Type of road closure. Some example values:              Open = road is open, not blocked, not closed, not restricted. It maybe that the disruption has been moved out of the carriageway.              Partial Closure = road is partially blocked, closed or restricted.               Full Closure = road is fully blocked or closed.</value>
    [DataMember(Name="closure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closure")]
    public string Closure { get; set; }

    /// <summary>
    /// The direction of the disruption on the street. Some example values:              All Directions              All Approaches              Clockwise              Anti-Clockwise              Northbound              Eastbound              Southbound              Westbound              Both Directions
    /// </summary>
    /// <value>The direction of the disruption on the street. Some example values:              All Directions              All Approaches              Clockwise              Anti-Clockwise              Northbound              Eastbound              Southbound              Westbound              Both Directions</value>
    [DataMember(Name="directions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directions")]
    public string Directions { get; set; }

    /// <summary>
    /// Geographic description of the sections of this street that are affected.
    /// </summary>
    /// <value>Geographic description of the sections of this street that are affected.</value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<TflApiPresentationEntitiesStreetSegment> Segments { get; set; }

    /// <summary>
    /// The ID from the source system of the disruption that this street belongs to.
    /// </summary>
    /// <value>The ID from the source system of the disruption that this street belongs to.</value>
    [DataMember(Name="sourceSystemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceSystemId")]
    public long? SourceSystemId { get; set; }

    /// <summary>
    /// The key of the source system of the disruption that this street belongs to.
    /// </summary>
    /// <value>The key of the source system of the disruption that this street belongs to.</value>
    [DataMember(Name="sourceSystemKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceSystemKey")]
    public string SourceSystemKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStreet {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Closure: ").Append(Closure).Append("\n");
      sb.Append("  Directions: ").Append(Directions).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      sb.Append("  SourceSystemId: ").Append(SourceSystemId).Append("\n");
      sb.Append("  SourceSystemKey: ").Append(SourceSystemKey).Append("\n");
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
