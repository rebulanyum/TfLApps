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
  public class TflApiPresentationEntitiesServiceFrequency {
    /// <summary>
    /// Gets or Sets LowestFrequency
    /// </summary>
    [DataMember(Name="lowestFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowestFrequency")]
    public double? LowestFrequency { get; set; }

    /// <summary>
    /// Gets or Sets HighestFrequency
    /// </summary>
    [DataMember(Name="highestFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highestFrequency")]
    public double? HighestFrequency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesServiceFrequency {\n");
      sb.Append("  LowestFrequency: ").Append(LowestFrequency).Append("\n");
      sb.Append("  HighestFrequency: ").Append(HighestFrequency).Append("\n");
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
