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
  public class TflApiPresentationEntitiesTimetableRoute {
    /// <summary>
    /// Gets or Sets StationIntervals
    /// </summary>
    [DataMember(Name="stationIntervals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationIntervals")]
    public List<TflApiPresentationEntitiesStationInterval> StationIntervals { get; set; }

    /// <summary>
    /// Gets or Sets Schedules
    /// </summary>
    [DataMember(Name="schedules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schedules")]
    public List<TflApiPresentationEntitiesSchedule> Schedules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesTimetableRoute {\n");
      sb.Append("  StationIntervals: ").Append(StationIntervals).Append("\n");
      sb.Append("  Schedules: ").Append(Schedules).Append("\n");
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
