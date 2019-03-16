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
  public class TflApiPresentationEntitiesStreetSegment {
    /// <summary>
    /// A 16 digit unique integer identifying a OS ITN (Ordnance Survey Integrated Transport Network) road link.
    /// </summary>
    /// <value>A 16 digit unique integer identifying a OS ITN (Ordnance Survey Integrated Transport Network) road link.</value>
    [DataMember(Name="toid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toid")]
    public string Toid { get; set; }

    /// <summary>
    /// geoJSON formatted LineString containing two latitude/longitude (WGS84) pairs that identify the start and end points of the street segment.
    /// </summary>
    /// <value>geoJSON formatted LineString containing two latitude/longitude (WGS84) pairs that identify the start and end points of the street segment.</value>
    [DataMember(Name="lineString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineString")]
    public string LineString { get; set; }

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
      sb.Append("class TflApiPresentationEntitiesStreetSegment {\n");
      sb.Append("  Toid: ").Append(Toid).Append("\n");
      sb.Append("  LineString: ").Append(LineString).Append("\n");
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
