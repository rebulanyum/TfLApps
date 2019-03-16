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
  public class TflApiPresentationEntitiesTrainLoading {
    /// <summary>
    /// The Line Name e.g. \"Victoria\"
    /// </summary>
    /// <value>The Line Name e.g. \"Victoria\"</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public string Line { get; set; }

    /// <summary>
    /// Direction of the Line e.g. NB, SB, WB etc.
    /// </summary>
    /// <value>Direction of the Line e.g. NB, SB, WB etc.</value>
    [DataMember(Name="lineDirection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineDirection")]
    public string LineDirection { get; set; }

    /// <summary>
    /// Direction displayed on the platform e.g. NB, SB, WB etc.
    /// </summary>
    /// <value>Direction displayed on the platform e.g. NB, SB, WB etc.</value>
    [DataMember(Name="platformDirection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformDirection")]
    public string PlatformDirection { get; set; }

    /// <summary>
    /// Direction in regards to Journey Planner i.e. inbound or outbound
    /// </summary>
    /// <value>Direction in regards to Journey Planner i.e. inbound or outbound</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Naptan of the adjacent station
    /// </summary>
    /// <value>Naptan of the adjacent station</value>
    [DataMember(Name="naptanTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanTo")]
    public string NaptanTo { get; set; }

    /// <summary>
    /// Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.
    /// </summary>
    /// <value>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</value>
    [DataMember(Name="timeSlice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeSlice")]
    public string TimeSlice { get; set; }

    /// <summary>
    /// Scale between 1-6,                1 = Very quiet, 2 = Quiet, 3 = Fairly busy, 4 = Busy, 5 = Very busy, 6 = Exceptionally busy
    /// </summary>
    /// <value>Scale between 1-6,                1 = Very quiet, 2 = Quiet, 3 = Fairly busy, 4 = Busy, 5 = Very busy, 6 = Exceptionally busy</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesTrainLoading {\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  LineDirection: ").Append(LineDirection).Append("\n");
      sb.Append("  PlatformDirection: ").Append(PlatformDirection).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  NaptanTo: ").Append(NaptanTo).Append("\n");
      sb.Append("  TimeSlice: ").Append(TimeSlice).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
