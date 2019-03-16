using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// Object that represents an end to end journey (see schematic).
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesJourneyPlannerJourney {
    /// <summary>
    /// Gets or Sets StartDateTime
    /// </summary>
    [DataMember(Name="startDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDateTime")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Gets or Sets ArrivalDateTime
    /// </summary>
    [DataMember(Name="arrivalDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalDateTime")]
    public DateTime? ArrivalDateTime { get; set; }

    /// <summary>
    /// Gets or Sets Legs
    /// </summary>
    [DataMember(Name="legs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legs")]
    public List<TflApiPresentationEntitiesJourneyPlannerLeg> Legs { get; set; }

    /// <summary>
    /// Gets or Sets Fare
    /// </summary>
    [DataMember(Name="fare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fare")]
    public TflApiPresentationEntitiesJourneyPlannerJourneyFare Fare { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerJourney {\n");
      sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  ArrivalDateTime: ").Append(ArrivalDateTime).Append("\n");
      sb.Append("  Legs: ").Append(Legs).Append("\n");
      sb.Append("  Fare: ").Append(Fare).Append("\n");
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
