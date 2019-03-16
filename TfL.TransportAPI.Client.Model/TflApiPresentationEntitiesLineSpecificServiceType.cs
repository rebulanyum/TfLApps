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
  public class TflApiPresentationEntitiesLineSpecificServiceType {
    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="serviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceType")]
    public TflApiPresentationEntitiesLineServiceTypeInfo ServiceType { get; set; }

    /// <summary>
    /// Gets or Sets StopServesServiceType
    /// </summary>
    [DataMember(Name="stopServesServiceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopServesServiceType")]
    public bool? StopServesServiceType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLineSpecificServiceType {\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  StopServesServiceType: ").Append(StopServesServiceType).Append("\n");
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
