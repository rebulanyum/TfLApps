using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// Represents a point located at a latitude and longitude using the WGS84 co-ordinate system.
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesPoint {
    /// <summary>
    /// WGS84 latitude of the location.
    /// </summary>
    /// <value>WGS84 latitude of the location.</value>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// WGS84 longitude of the location.
    /// </summary>
    /// <value>WGS84 longitude of the location.</value>
    [DataMember(Name="lon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lon")]
    public double? Lon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPoint {\n");
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      sb.Append("  Lon: ").Append(Lon).Append("\n");
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
