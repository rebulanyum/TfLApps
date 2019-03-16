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
  public class TflApiPresentationEntitiesMatchedStop {
    /// <summary>
    /// Gets or Sets RouteId
    /// </summary>
    [DataMember(Name="routeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeId")]
    public int? RouteId { get; set; }

    /// <summary>
    /// Gets or Sets ParentId
    /// </summary>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public string ParentId { get; set; }

    /// <summary>
    /// Gets or Sets StationId
    /// </summary>
    [DataMember(Name="stationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationId")]
    public string StationId { get; set; }

    /// <summary>
    /// Gets or Sets IcsId
    /// </summary>
    [DataMember(Name="icsId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icsId")]
    public string IcsId { get; set; }

    /// <summary>
    /// Gets or Sets TopMostParentId
    /// </summary>
    [DataMember(Name="topMostParentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topMostParentId")]
    public string TopMostParentId { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets Towards
    /// </summary>
    [DataMember(Name="towards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "towards")]
    public string Towards { get; set; }

    /// <summary>
    /// Gets or Sets Modes
    /// </summary>
    [DataMember(Name="modes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modes")]
    public List<string> Modes { get; set; }

    /// <summary>
    /// Gets or Sets StopType
    /// </summary>
    [DataMember(Name="stopType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopType")]
    public string StopType { get; set; }

    /// <summary>
    /// Gets or Sets StopLetter
    /// </summary>
    [DataMember(Name="stopLetter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLetter")]
    public string StopLetter { get; set; }

    /// <summary>
    /// Gets or Sets Zone
    /// </summary>
    [DataMember(Name="zone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zone")]
    public string Zone { get; set; }

    /// <summary>
    /// Gets or Sets AccessibilitySummary
    /// </summary>
    [DataMember(Name="accessibilitySummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessibilitySummary")]
    public string AccessibilitySummary { get; set; }

    /// <summary>
    /// Gets or Sets HasDisruption
    /// </summary>
    [DataMember(Name="hasDisruption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasDisruption")]
    public bool? HasDisruption { get; set; }

    /// <summary>
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lines")]
    public List<TflApiPresentationEntitiesIdentifier> Lines { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public bool? Status { get; set; }

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
      sb.Append("class TflApiPresentationEntitiesMatchedStop {\n");
      sb.Append("  RouteId: ").Append(RouteId).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  StationId: ").Append(StationId).Append("\n");
      sb.Append("  IcsId: ").Append(IcsId).Append("\n");
      sb.Append("  TopMostParentId: ").Append(TopMostParentId).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Towards: ").Append(Towards).Append("\n");
      sb.Append("  Modes: ").Append(Modes).Append("\n");
      sb.Append("  StopType: ").Append(StopType).Append("\n");
      sb.Append("  StopLetter: ").Append(StopLetter).Append("\n");
      sb.Append("  Zone: ").Append(Zone).Append("\n");
      sb.Append("  AccessibilitySummary: ").Append(AccessibilitySummary).Append("\n");
      sb.Append("  HasDisruption: ").Append(HasDisruption).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
