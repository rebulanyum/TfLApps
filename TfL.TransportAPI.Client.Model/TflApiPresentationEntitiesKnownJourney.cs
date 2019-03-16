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
  public class TflApiPresentationEntitiesKnownJourney {
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
    /// Gets or Sets IntervalId
    /// </summary>
    [DataMember(Name="intervalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalId")]
    public int? IntervalId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesKnownJourney {\n");
      sb.Append("  Hour: ").Append(Hour).Append("\n");
      sb.Append("  Minute: ").Append(Minute).Append("\n");
      sb.Append("  IntervalId: ").Append(IntervalId).Append("\n");
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
