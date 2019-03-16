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
  public class TflApiPresentationEntitiesMode {
    /// <summary>
    /// Gets or Sets IsTflService
    /// </summary>
    [DataMember(Name="isTflService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTflService")]
    public bool? IsTflService { get; set; }

    /// <summary>
    /// Gets or Sets IsFarePaying
    /// </summary>
    [DataMember(Name="isFarePaying", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFarePaying")]
    public bool? IsFarePaying { get; set; }

    /// <summary>
    /// Gets or Sets IsScheduledService
    /// </summary>
    [DataMember(Name="isScheduledService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isScheduledService")]
    public bool? IsScheduledService { get; set; }

    /// <summary>
    /// Gets or Sets ModeName
    /// </summary>
    [DataMember(Name="modeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeName")]
    public string ModeName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesMode {\n");
      sb.Append("  IsTflService: ").Append(IsTflService).Append("\n");
      sb.Append("  IsFarePaying: ").Append(IsFarePaying).Append("\n");
      sb.Append("  IsScheduledService: ").Append(IsScheduledService).Append("\n");
      sb.Append("  ModeName: ").Append(ModeName).Append("\n");
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
