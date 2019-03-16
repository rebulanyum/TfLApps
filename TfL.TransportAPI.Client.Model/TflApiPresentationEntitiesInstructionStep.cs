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
  public class TflApiPresentationEntitiesInstructionStep {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets TurnDirection
    /// </summary>
    [DataMember(Name="turnDirection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "turnDirection")]
    public string TurnDirection { get; set; }

    /// <summary>
    /// Gets or Sets StreetName
    /// </summary>
    [DataMember(Name="streetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streetName")]
    public string StreetName { get; set; }

    /// <summary>
    /// Gets or Sets Distance
    /// </summary>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public int? Distance { get; set; }

    /// <summary>
    /// Gets or Sets CumulativeDistance
    /// </summary>
    [DataMember(Name="cumulativeDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cumulativeDistance")]
    public int? CumulativeDistance { get; set; }

    /// <summary>
    /// Gets or Sets SkyDirection
    /// </summary>
    [DataMember(Name="skyDirection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skyDirection")]
    public int? SkyDirection { get; set; }

    /// <summary>
    /// Gets or Sets SkyDirectionDescription
    /// </summary>
    [DataMember(Name="skyDirectionDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skyDirectionDescription")]
    public string SkyDirectionDescription { get; set; }

    /// <summary>
    /// Gets or Sets CumulativeTravelTime
    /// </summary>
    [DataMember(Name="cumulativeTravelTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cumulativeTravelTime")]
    public int? CumulativeTravelTime { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Gets or Sets PathAttribute
    /// </summary>
    [DataMember(Name="pathAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pathAttribute")]
    public TflApiPresentationEntitiesPathAttribute PathAttribute { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionHeading
    /// </summary>
    [DataMember(Name="descriptionHeading", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "descriptionHeading")]
    public string DescriptionHeading { get; set; }

    /// <summary>
    /// Gets or Sets TrackType
    /// </summary>
    [DataMember(Name="trackType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackType")]
    public string TrackType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesInstructionStep {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TurnDirection: ").Append(TurnDirection).Append("\n");
      sb.Append("  StreetName: ").Append(StreetName).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  CumulativeDistance: ").Append(CumulativeDistance).Append("\n");
      sb.Append("  SkyDirection: ").Append(SkyDirection).Append("\n");
      sb.Append("  SkyDirectionDescription: ").Append(SkyDirectionDescription).Append("\n");
      sb.Append("  CumulativeTravelTime: ").Append(CumulativeTravelTime).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  PathAttribute: ").Append(PathAttribute).Append("\n");
      sb.Append("  DescriptionHeading: ").Append(DescriptionHeading).Append("\n");
      sb.Append("  TrackType: ").Append(TrackType).Append("\n");
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
