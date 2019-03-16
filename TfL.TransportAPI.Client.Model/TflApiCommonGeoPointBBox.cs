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
  public class TflApiCommonGeoPointBBox {
    /// <summary>
    /// Gets or Sets SwLat
    /// </summary>
    [DataMember(Name="swLat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swLat")]
    public double? SwLat { get; set; }

    /// <summary>
    /// Gets or Sets SwLon
    /// </summary>
    [DataMember(Name="swLon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "swLon")]
    public double? SwLon { get; set; }

    /// <summary>
    /// Gets or Sets NeLat
    /// </summary>
    [DataMember(Name="neLat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "neLat")]
    public double? NeLat { get; set; }

    /// <summary>
    /// Gets or Sets NeLon
    /// </summary>
    [DataMember(Name="neLon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "neLon")]
    public double? NeLon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiCommonGeoPointBBox {\n");
      sb.Append("  SwLat: ").Append(SwLat).Append("\n");
      sb.Append("  SwLon: ").Append(SwLon).Append("\n");
      sb.Append("  NeLat: ").Append(NeLat).Append("\n");
      sb.Append("  NeLon: ").Append(NeLon).Append("\n");
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
