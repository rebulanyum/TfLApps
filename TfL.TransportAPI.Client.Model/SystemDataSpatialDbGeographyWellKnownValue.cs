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
  public class SystemDataSpatialDbGeographyWellKnownValue {
    /// <summary>
    /// Gets or Sets CoordinateSystemId
    /// </summary>
    [DataMember(Name="coordinateSystemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coordinateSystemId")]
    public int? CoordinateSystemId { get; set; }

    /// <summary>
    /// Gets or Sets WellKnownText
    /// </summary>
    [DataMember(Name="wellKnownText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wellKnownText")]
    public string WellKnownText { get; set; }

    /// <summary>
    /// Gets or Sets WellKnownBinary
    /// </summary>
    [DataMember(Name="wellKnownBinary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wellKnownBinary")]
    public byte[] WellKnownBinary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SystemDataSpatialDbGeographyWellKnownValue {\n");
      sb.Append("  CoordinateSystemId: ").Append(CoordinateSystemId).Append("\n");
      sb.Append("  WellKnownText: ").Append(WellKnownText).Append("\n");
      sb.Append("  WellKnownBinary: ").Append(WellKnownBinary).Append("\n");
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
