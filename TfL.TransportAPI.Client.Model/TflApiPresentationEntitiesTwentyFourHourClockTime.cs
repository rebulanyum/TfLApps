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
  public class TflApiPresentationEntitiesTwentyFourHourClockTime {
    /// <summary>
    /// Gets or Sets Hour
    /// </summary>
    [DataMember(Name="hour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hour")]
    public string Hour { get; set; }

    /// <summary>
    /// Gets or Sets Minute
    /// </summary>
    [DataMember(Name="minute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minute")]
    public string Minute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesTwentyFourHourClockTime {\n");
      sb.Append("  Hour: ").Append(Hour).Append("\n");
      sb.Append("  Minute: ").Append(Minute).Append("\n");
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
