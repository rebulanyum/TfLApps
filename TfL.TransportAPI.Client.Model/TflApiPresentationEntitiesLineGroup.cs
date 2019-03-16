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
  public class TflApiPresentationEntitiesLineGroup {
    /// <summary>
    /// Gets or Sets NaptanIdReference
    /// </summary>
    [DataMember(Name="naptanIdReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanIdReference")]
    public string NaptanIdReference { get; set; }

    /// <summary>
    /// Gets or Sets StationAtcoCode
    /// </summary>
    [DataMember(Name="stationAtcoCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationAtcoCode")]
    public string StationAtcoCode { get; set; }

    /// <summary>
    /// Gets or Sets LineIdentifier
    /// </summary>
    [DataMember(Name="lineIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineIdentifier")]
    public List<string> LineIdentifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLineGroup {\n");
      sb.Append("  NaptanIdReference: ").Append(NaptanIdReference).Append("\n");
      sb.Append("  StationAtcoCode: ").Append(StationAtcoCode).Append("\n");
      sb.Append("  LineIdentifier: ").Append(LineIdentifier).Append("\n");
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
