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
  public class TflApiPresentationEntitiesStopPointSequence {
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
    /// The id of this branch.
    /// </summary>
    /// <value>The id of this branch.</value>
    [DataMember(Name="branchId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branchId")]
    public int? BranchId { get; set; }

    /// <summary>
    /// The ids of the next branch(es) in the sequence. Note that the next and previous branch id can be              identical in the case of a looped route e.g. the Circle line.
    /// </summary>
    /// <value>The ids of the next branch(es) in the sequence. Note that the next and previous branch id can be              identical in the case of a looped route e.g. the Circle line.</value>
    [DataMember(Name="nextBranchIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextBranchIds")]
    public List<int?> NextBranchIds { get; set; }

    /// <summary>
    /// The ids of the previous branch(es) in the sequence. Note that the next and previous branch id can be              identical in the case of a looped route e.g. the Circle line.
    /// </summary>
    /// <value>The ids of the previous branch(es) in the sequence. Note that the next and previous branch id can be              identical in the case of a looped route e.g. the Circle line.</value>
    [DataMember(Name="prevBranchIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prevBranchIds")]
    public List<int?> PrevBranchIds { get; set; }

    /// <summary>
    /// Gets or Sets StopPoint
    /// </summary>
    [DataMember(Name="stopPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopPoint")]
    public List<TflApiPresentationEntitiesMatchedStop> StopPoint { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="serviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceType")]
    public string ServiceType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStopPointSequence {\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  BranchId: ").Append(BranchId).Append("\n");
      sb.Append("  NextBranchIds: ").Append(NextBranchIds).Append("\n");
      sb.Append("  PrevBranchIds: ").Append(PrevBranchIds).Append("\n");
      sb.Append("  StopPoint: ").Append(StopPoint).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
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
