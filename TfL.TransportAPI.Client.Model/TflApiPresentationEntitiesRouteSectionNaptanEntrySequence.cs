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
  public class TflApiPresentationEntitiesRouteSectionNaptanEntrySequence {
    /// <summary>
    /// Gets or Sets Ordinal
    /// </summary>
    [DataMember(Name="ordinal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordinal")]
    public int? Ordinal { get; set; }

    /// <summary>
    /// Gets or Sets StopPoint
    /// </summary>
    [DataMember(Name="stopPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopPoint")]
    public TflApiPresentationEntitiesStopPoint StopPoint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRouteSectionNaptanEntrySequence {\n");
      sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
      sb.Append("  StopPoint: ").Append(StopPoint).Append("\n");
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
