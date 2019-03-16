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
  public class TflApiPresentationEntitiesCoordinate {
    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Easting
    /// </summary>
    [DataMember(Name="easting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "easting")]
    public double? Easting { get; set; }

    /// <summary>
    /// Gets or Sets Northing
    /// </summary>
    [DataMember(Name="northing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "northing")]
    public double? Northing { get; set; }

    /// <summary>
    /// Gets or Sets XCoord
    /// </summary>
    [DataMember(Name="xCoord", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xCoord")]
    public int? XCoord { get; set; }

    /// <summary>
    /// Gets or Sets YCoord
    /// </summary>
    [DataMember(Name="yCoord", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yCoord")]
    public int? YCoord { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesCoordinate {\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Easting: ").Append(Easting).Append("\n");
      sb.Append("  Northing: ").Append(Northing).Append("\n");
      sb.Append("  XCoord: ").Append(XCoord).Append("\n");
      sb.Append("  YCoord: ").Append(YCoord).Append("\n");
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
