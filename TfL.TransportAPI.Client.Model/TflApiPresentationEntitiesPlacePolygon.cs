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
  public class TflApiPresentationEntitiesPlacePolygon {
    /// <summary>
    /// Gets or Sets GeoPoints
    /// </summary>
    [DataMember(Name="geoPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geoPoints")]
    public List<TflApiCommonGeoPoint> GeoPoints { get; set; }

    /// <summary>
    /// Gets or Sets CommonName
    /// </summary>
    [DataMember(Name="commonName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonName")]
    public string CommonName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPlacePolygon {\n");
      sb.Append("  GeoPoints: ").Append(GeoPoints).Append("\n");
      sb.Append("  CommonName: ").Append(CommonName).Append("\n");
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
