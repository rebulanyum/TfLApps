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
  public class TflApiPresentationEntitiesPeriod {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets FromTime
    /// </summary>
    [DataMember(Name="fromTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromTime")]
    public TflApiPresentationEntitiesTwentyFourHourClockTime FromTime { get; set; }

    /// <summary>
    /// Gets or Sets ToTime
    /// </summary>
    [DataMember(Name="toTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toTime")]
    public TflApiPresentationEntitiesTwentyFourHourClockTime ToTime { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public TflApiPresentationEntitiesServiceFrequency Frequency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPeriod {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  FromTime: ").Append(FromTime).Append("\n");
      sb.Append("  ToTime: ").Append(ToTime).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
