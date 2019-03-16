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
  public class TflApiPresentationEntitiesInstruction {
    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or Sets Detailed
    /// </summary>
    [DataMember(Name="detailed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailed")]
    public string Detailed { get; set; }

    /// <summary>
    /// Gets or Sets Steps
    /// </summary>
    [DataMember(Name="steps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "steps")]
    public List<TflApiPresentationEntitiesInstructionStep> Steps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesInstruction {\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  Detailed: ").Append(Detailed).Append("\n");
      sb.Append("  Steps: ").Append(Steps).Append("\n");
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
