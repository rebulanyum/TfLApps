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
  public class TflApiCommonJourneyPlannerJpElevation {
    /// <summary>
    /// Gets or Sets Distance
    /// </summary>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public int? Distance { get; set; }

    /// <summary>
    /// Gets or Sets StartLat
    /// </summary>
    [DataMember(Name="startLat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startLat")]
    public double? StartLat { get; set; }

    /// <summary>
    /// Gets or Sets StartLon
    /// </summary>
    [DataMember(Name="startLon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startLon")]
    public double? StartLon { get; set; }

    /// <summary>
    /// Gets or Sets EndLat
    /// </summary>
    [DataMember(Name="endLat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endLat")]
    public double? EndLat { get; set; }

    /// <summary>
    /// Gets or Sets EndLon
    /// </summary>
    [DataMember(Name="endLon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endLon")]
    public double? EndLon { get; set; }

    /// <summary>
    /// Gets or Sets HeightFromPreviousPoint
    /// </summary>
    [DataMember(Name="heightFromPreviousPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heightFromPreviousPoint")]
    public int? HeightFromPreviousPoint { get; set; }

    /// <summary>
    /// Gets or Sets Gradient
    /// </summary>
    [DataMember(Name="gradient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gradient")]
    public double? Gradient { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiCommonJourneyPlannerJpElevation {\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  StartLat: ").Append(StartLat).Append("\n");
      sb.Append("  StartLon: ").Append(StartLon).Append("\n");
      sb.Append("  EndLat: ").Append(EndLat).Append("\n");
      sb.Append("  EndLon: ").Append(EndLon).Append("\n");
      sb.Append("  HeightFromPreviousPoint: ").Append(HeightFromPreviousPoint).Append("\n");
      sb.Append("  Gradient: ").Append(Gradient).Append("\n");
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
