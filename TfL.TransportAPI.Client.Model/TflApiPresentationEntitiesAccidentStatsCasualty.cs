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
  public class TflApiPresentationEntitiesAccidentStatsCasualty {
    /// <summary>
    /// Gets or Sets Age
    /// </summary>
    [DataMember(Name="age", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "age")]
    public int? Age { get; set; }

    /// <summary>
    /// Gets or Sets Class
    /// </summary>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public string Class { get; set; }

    /// <summary>
    /// Gets or Sets Severity
    /// </summary>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets AgeBand
    /// </summary>
    [DataMember(Name="ageBand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ageBand")]
    public string AgeBand { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesAccidentStatsCasualty {\n");
      sb.Append("  Age: ").Append(Age).Append("\n");
      sb.Append("  Class: ").Append(Class).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  AgeBand: ").Append(AgeBand).Append("\n");
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
