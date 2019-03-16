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
  public class TflApiPresentationEntitiesJourneyPlannerLeg {
    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Gets or Sets Speed
    /// </summary>
    [DataMember(Name="speed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "speed")]
    public string Speed { get; set; }

    /// <summary>
    /// Describes the action the user need to take for this section, E.g. \"walk to the              district line\"
    /// </summary>
    /// <value>Describes the action the user need to take for this section, E.g. \"walk to the              district line\"</value>
    [DataMember(Name="instruction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instruction")]
    public TflApiPresentationEntitiesInstruction Instruction { get; set; }

    /// <summary>
    /// Gets or Sets Obstacles
    /// </summary>
    [DataMember(Name="obstacles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obstacles")]
    public List<TflApiPresentationEntitiesJourneyPlannerObstacle> Obstacles { get; set; }

    /// <summary>
    /// Gets or Sets DepartureTime
    /// </summary>
    [DataMember(Name="departureTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureTime")]
    public DateTime? DepartureTime { get; set; }

    /// <summary>
    /// Gets or Sets ArrivalTime
    /// </summary>
    [DataMember(Name="arrivalTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalTime")]
    public DateTime? ArrivalTime { get; set; }

    /// <summary>
    /// Gets or Sets DeparturePoint
    /// </summary>
    [DataMember(Name="departurePoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departurePoint")]
    public TflApiPresentationEntitiesPoint DeparturePoint { get; set; }

    /// <summary>
    /// Gets or Sets ArrivalPoint
    /// </summary>
    [DataMember(Name="arrivalPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalPoint")]
    public TflApiPresentationEntitiesPoint ArrivalPoint { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public TflApiPresentationEntitiesJourneyPlannerPath Path { get; set; }

    /// <summary>
    /// Gets or Sets RouteOptions
    /// </summary>
    [DataMember(Name="routeOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeOptions")]
    public List<TflApiPresentationEntitiesJourneyPlannerRouteOption> RouteOptions { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public TflApiPresentationEntitiesIdentifier Mode { get; set; }

    /// <summary>
    /// Gets or Sets Disruptions
    /// </summary>
    [DataMember(Name="disruptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disruptions")]
    public List<TflApiPresentationEntitiesDisruption> Disruptions { get; set; }

    /// <summary>
    /// Gets or Sets PlannedWorks
    /// </summary>
    [DataMember(Name="plannedWorks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plannedWorks")]
    public List<TflApiPresentationEntitiesJourneyPlannerPlannedWork> PlannedWorks { get; set; }

    /// <summary>
    /// Gets or Sets Distance
    /// </summary>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public double? Distance { get; set; }

    /// <summary>
    /// Gets or Sets IsDisrupted
    /// </summary>
    [DataMember(Name="isDisrupted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDisrupted")]
    public bool? IsDisrupted { get; set; }

    /// <summary>
    /// Gets or Sets HasFixedLocations
    /// </summary>
    [DataMember(Name="hasFixedLocations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasFixedLocations")]
    public bool? HasFixedLocations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerLeg {\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Speed: ").Append(Speed).Append("\n");
      sb.Append("  Instruction: ").Append(Instruction).Append("\n");
      sb.Append("  Obstacles: ").Append(Obstacles).Append("\n");
      sb.Append("  DepartureTime: ").Append(DepartureTime).Append("\n");
      sb.Append("  ArrivalTime: ").Append(ArrivalTime).Append("\n");
      sb.Append("  DeparturePoint: ").Append(DeparturePoint).Append("\n");
      sb.Append("  ArrivalPoint: ").Append(ArrivalPoint).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  RouteOptions: ").Append(RouteOptions).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Disruptions: ").Append(Disruptions).Append("\n");
      sb.Append("  PlannedWorks: ").Append(PlannedWorks).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  IsDisrupted: ").Append(IsDisrupted).Append("\n");
      sb.Append("  HasFixedLocations: ").Append(HasFixedLocations).Append("\n");
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
