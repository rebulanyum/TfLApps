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
  public class TflApiPresentationEntitiesStatusSeverity {
    /// <summary>
    /// Gets or Sets ModeName
    /// </summary>
    [DataMember(Name="modeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeName")]
    public string ModeName { get; set; }

    /// <summary>
    /// Gets or Sets SeverityLevel
    /// </summary>
    [DataMember(Name="severityLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severityLevel")]
    public int? SeverityLevel { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStatusSeverity {\n");
      sb.Append("  ModeName: ").Append(ModeName).Append("\n");
      sb.Append("  SeverityLevel: ").Append(SeverityLevel).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
