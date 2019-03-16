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
  public class TflApiPresentationEntitiesJourneyPlannerPath {
    /// <summary>
    /// Gets or Sets LineString
    /// </summary>
    [DataMember(Name="lineString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineString")]
    public string LineString { get; set; }

    /// <summary>
    /// Gets or Sets StopPoints
    /// </summary>
    [DataMember(Name="stopPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopPoints")]
    public List<TflApiPresentationEntitiesIdentifier> StopPoints { get; set; }

    /// <summary>
    /// Gets or Sets Elevation
    /// </summary>
    [DataMember(Name="elevation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation")]
    public List<TflApiCommonJourneyPlannerJpElevation> Elevation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerPath {\n");
      sb.Append("  LineString: ").Append(LineString).Append("\n");
      sb.Append("  StopPoints: ").Append(StopPoints).Append("\n");
      sb.Append("  Elevation: ").Append(Elevation).Append("\n");
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
