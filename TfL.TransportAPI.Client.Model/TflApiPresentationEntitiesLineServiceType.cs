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
  public class TflApiPresentationEntitiesLineServiceType {
    /// <summary>
    /// Gets or Sets LineName
    /// </summary>
    [DataMember(Name="lineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineName")]
    public string LineName { get; set; }

    /// <summary>
    /// Gets or Sets LineSpecificServiceTypes
    /// </summary>
    [DataMember(Name="lineSpecificServiceTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineSpecificServiceTypes")]
    public List<TflApiPresentationEntitiesLineSpecificServiceType> LineSpecificServiceTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLineServiceType {\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  LineSpecificServiceTypes: ").Append(LineSpecificServiceTypes).Append("\n");
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
