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
  public class TflApiPresentationEntitiesJourneyPlannerJourneyPlannerCycleHireDockingStationData {
    /// <summary>
    /// Gets or Sets OriginNumberOfBikes
    /// </summary>
    [DataMember(Name="originNumberOfBikes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originNumberOfBikes")]
    public int? OriginNumberOfBikes { get; set; }

    /// <summary>
    /// Gets or Sets DestinationNumberOfBikes
    /// </summary>
    [DataMember(Name="destinationNumberOfBikes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationNumberOfBikes")]
    public int? DestinationNumberOfBikes { get; set; }

    /// <summary>
    /// Gets or Sets OriginNumberOfEmptySlots
    /// </summary>
    [DataMember(Name="originNumberOfEmptySlots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originNumberOfEmptySlots")]
    public int? OriginNumberOfEmptySlots { get; set; }

    /// <summary>
    /// Gets or Sets DestinationNumberOfEmptySlots
    /// </summary>
    [DataMember(Name="destinationNumberOfEmptySlots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationNumberOfEmptySlots")]
    public int? DestinationNumberOfEmptySlots { get; set; }

    /// <summary>
    /// Gets or Sets OriginId
    /// </summary>
    [DataMember(Name="originId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originId")]
    public string OriginId { get; set; }

    /// <summary>
    /// Gets or Sets DestinationId
    /// </summary>
    [DataMember(Name="destinationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationId")]
    public string DestinationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerJourneyPlannerCycleHireDockingStationData {\n");
      sb.Append("  OriginNumberOfBikes: ").Append(OriginNumberOfBikes).Append("\n");
      sb.Append("  DestinationNumberOfBikes: ").Append(DestinationNumberOfBikes).Append("\n");
      sb.Append("  OriginNumberOfEmptySlots: ").Append(OriginNumberOfEmptySlots).Append("\n");
      sb.Append("  DestinationNumberOfEmptySlots: ").Append(DestinationNumberOfEmptySlots).Append("\n");
      sb.Append("  OriginId: ").Append(OriginId).Append("\n");
      sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
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
