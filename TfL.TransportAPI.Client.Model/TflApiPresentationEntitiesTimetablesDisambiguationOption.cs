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
  public class TflApiPresentationEntitiesTimetablesDisambiguationOption {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesTimetablesDisambiguationOption {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
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
