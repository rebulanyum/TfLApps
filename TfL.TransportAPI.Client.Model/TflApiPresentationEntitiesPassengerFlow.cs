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
  public class TflApiPresentationEntitiesPassengerFlow {
    /// <summary>
    /// Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.
    /// </summary>
    /// <value>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</value>
    [DataMember(Name="timeSlice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeSlice")]
    public string TimeSlice { get; set; }

    /// <summary>
    /// Count of passenger flow towards a platform
    /// </summary>
    /// <value>Count of passenger flow towards a platform</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public int? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPassengerFlow {\n");
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
