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
  public class TflApiPresentationEntitiesBay {
    /// <summary>
    /// Gets or Sets BayType
    /// </summary>
    [DataMember(Name="bayType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bayType")]
    public string BayType { get; set; }

    /// <summary>
    /// Gets or Sets BayCount
    /// </summary>
    [DataMember(Name="bayCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bayCount")]
    public int? BayCount { get; set; }

    /// <summary>
    /// Gets or Sets Free
    /// </summary>
    [DataMember(Name="free", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "free")]
    public int? Free { get; set; }

    /// <summary>
    /// Gets or Sets Occupied
    /// </summary>
    [DataMember(Name="occupied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occupied")]
    public int? Occupied { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesBay {\n");
      sb.Append("  BayType: ").Append(BayType).Append("\n");
      sb.Append("  BayCount: ").Append(BayCount).Append("\n");
      sb.Append("  Free: ").Append(Free).Append("\n");
      sb.Append("  Occupied: ").Append(Occupied).Append("\n");
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
