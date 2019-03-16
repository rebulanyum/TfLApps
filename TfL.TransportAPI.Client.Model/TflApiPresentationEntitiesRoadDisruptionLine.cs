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
  public class TflApiPresentationEntitiesRoadDisruptionLine {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets RoadDisruptionId
    /// </summary>
    [DataMember(Name="roadDisruptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roadDisruptionId")]
    public string RoadDisruptionId { get; set; }

    /// <summary>
    /// Gets or Sets IsDiversion
    /// </summary>
    [DataMember(Name="isDiversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDiversion")]
    public bool? IsDiversion { get; set; }

    /// <summary>
    /// Gets or Sets MultiLineString
    /// </summary>
    [DataMember(Name="multiLineString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiLineString")]
    public SystemDataSpatialDbGeography MultiLineString { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="endTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTime")]
    public string EndTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRoadDisruptionLine {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RoadDisruptionId: ").Append(RoadDisruptionId).Append("\n");
      sb.Append("  IsDiversion: ").Append(IsDiversion).Append("\n");
      sb.Append("  MultiLineString: ").Append(MultiLineString).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
