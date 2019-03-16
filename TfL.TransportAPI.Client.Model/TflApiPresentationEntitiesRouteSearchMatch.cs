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
  public class TflApiPresentationEntitiesRouteSearchMatch {
    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets LineName
    /// </summary>
    [DataMember(Name="lineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineName")]
    public string LineName { get; set; }

    /// <summary>
    /// Gets or Sets LineRouteSection
    /// </summary>
    [DataMember(Name="lineRouteSection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineRouteSection")]
    public List<TflApiPresentationEntitiesLineRouteSection> LineRouteSection { get; set; }

    /// <summary>
    /// Gets or Sets MatchedRouteSections
    /// </summary>
    [DataMember(Name="matchedRouteSections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matchedRouteSections")]
    public List<TflApiPresentationEntitiesMatchedRouteSections> MatchedRouteSections { get; set; }

    /// <summary>
    /// Gets or Sets MatchedStops
    /// </summary>
    [DataMember(Name="matchedStops", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matchedStops")]
    public List<TflApiPresentationEntitiesMatchedStop> MatchedStops { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Lat
    /// </summary>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// Gets or Sets Lon
    /// </summary>
    [DataMember(Name="lon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lon")]
    public double? Lon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRouteSearchMatch {\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  LineRouteSection: ").Append(LineRouteSection).Append("\n");
      sb.Append("  MatchedRouteSections: ").Append(MatchedRouteSections).Append("\n");
      sb.Append("  MatchedStops: ").Append(MatchedStops).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
