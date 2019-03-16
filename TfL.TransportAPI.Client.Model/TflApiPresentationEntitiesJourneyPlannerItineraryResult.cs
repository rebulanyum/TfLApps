using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// A DTO representing a list of possible journeys.
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesJourneyPlannerItineraryResult {
    /// <summary>
    /// Gets or Sets Journeys
    /// </summary>
    [DataMember(Name="journeys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journeys")]
    public List<TflApiPresentationEntitiesJourneyPlannerJourney> Journeys { get; set; }

    /// <summary>
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lines")]
    public List<TflApiPresentationEntitiesLine> Lines { get; set; }

    /// <summary>
    /// Gets or Sets CycleHireDockingStationData
    /// </summary>
    [DataMember(Name="cycleHireDockingStationData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cycleHireDockingStationData")]
    public TflApiPresentationEntitiesJourneyPlannerJourneyPlannerCycleHireDockingStationData CycleHireDockingStationData { get; set; }

    /// <summary>
    /// Gets or Sets StopMessages
    /// </summary>
    [DataMember(Name="stopMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopMessages")]
    public List<string> StopMessages { get; set; }

    /// <summary>
    /// Gets or Sets RecommendedMaxAgeMinutes
    /// </summary>
    [DataMember(Name="recommendedMaxAgeMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendedMaxAgeMinutes")]
    public int? RecommendedMaxAgeMinutes { get; set; }

    /// <summary>
    /// Gets or Sets SearchCriteria
    /// </summary>
    [DataMember(Name="searchCriteria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchCriteria")]
    public TflApiPresentationEntitiesJourneyPlannerSearchCriteria SearchCriteria { get; set; }

    /// <summary>
    /// Gets or Sets JourneyVector
    /// </summary>
    [DataMember(Name="journeyVector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journeyVector")]
    public TflApiPresentationEntitiesJourneyPlannerJourneyVector JourneyVector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerItineraryResult {\n");
      sb.Append("  Journeys: ").Append(Journeys).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
      sb.Append("  CycleHireDockingStationData: ").Append(CycleHireDockingStationData).Append("\n");
      sb.Append("  StopMessages: ").Append(StopMessages).Append("\n");
      sb.Append("  RecommendedMaxAgeMinutes: ").Append(RecommendedMaxAgeMinutes).Append("\n");
      sb.Append("  SearchCriteria: ").Append(SearchCriteria).Append("\n");
      sb.Append("  JourneyVector: ").Append(JourneyVector).Append("\n");
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
