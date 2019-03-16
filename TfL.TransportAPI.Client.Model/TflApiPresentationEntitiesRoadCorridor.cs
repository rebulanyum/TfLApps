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
  public class TflApiPresentationEntitiesRoadCorridor {
    /// <summary>
    /// The Id of the Corridor e.g. \"A406\"
    /// </summary>
    /// <value>The Id of the Corridor e.g. \"A406\"</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The display name of the Corridor e.g. \"North Circular (A406)\". This              may be identical to the Id.
    /// </summary>
    /// <value>The display name of the Corridor e.g. \"North Circular (A406)\". This              may be identical to the Id.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The group name of the Corridor e.g. \"Central London\". Most corridors are not grouped, in which case this field can be null.
    /// </summary>
    /// <value>The group name of the Corridor e.g. \"Central London\". Most corridors are not grouped, in which case this field can be null.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// Standard multi-mode status severity code
    /// </summary>
    /// <value>Standard multi-mode status severity code</value>
    [DataMember(Name="statusSeverity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusSeverity")]
    public string StatusSeverity { get; set; }

    /// <summary>
    /// Description of the status severity as applied to RoadCorridors
    /// </summary>
    /// <value>Description of the status severity as applied to RoadCorridors</value>
    [DataMember(Name="statusSeverityDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusSeverityDescription")]
    public string StatusSeverityDescription { get; set; }

    /// <summary>
    /// The Bounds of the Corridor, given by the south-east followed by the north-west co-ordinate              pair in geoJSON format e.g. \"[[-1.241531,51.242151],[1.641223,53.765721]]\"
    /// </summary>
    /// <value>The Bounds of the Corridor, given by the south-east followed by the north-west co-ordinate              pair in geoJSON format e.g. \"[[-1.241531,51.242151],[1.641223,53.765721]]\"</value>
    [DataMember(Name="bounds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bounds")]
    public string Bounds { get; set; }

    /// <summary>
    /// The Envelope of the Corridor, given by the corner co-ordinates of a rectangular (four-point) polygon              in geoJSON format e.g. \"[[-1.241531,51.242151],[-1.241531,53.765721],[1.641223,53.765721],[1.641223,51.242151]]\"
    /// </summary>
    /// <value>The Envelope of the Corridor, given by the corner co-ordinates of a rectangular (four-point) polygon              in geoJSON format e.g. \"[[-1.241531,51.242151],[-1.241531,53.765721],[1.641223,53.765721],[1.641223,51.242151]]\"</value>
    [DataMember(Name="envelope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "envelope")]
    public string Envelope { get; set; }

    /// <summary>
    /// The start of the period over which status has been aggregated, or null if this is the current corridor status.
    /// </summary>
    /// <value>The start of the period over which status has been aggregated, or null if this is the current corridor status.</value>
    [DataMember(Name="statusAggregationStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusAggregationStartDate")]
    public DateTime? StatusAggregationStartDate { get; set; }

    /// <summary>
    /// The end of the period over which status has been aggregated, or null if this is the current corridor status.
    /// </summary>
    /// <value>The end of the period over which status has been aggregated, or null if this is the current corridor status.</value>
    [DataMember(Name="statusAggregationEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusAggregationEndDate")]
    public DateTime? StatusAggregationEndDate { get; set; }

    /// <summary>
    /// URL to retrieve this Corridor.
    /// </summary>
    /// <value>URL to retrieve this Corridor.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRoadCorridor {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  StatusSeverity: ").Append(StatusSeverity).Append("\n");
      sb.Append("  StatusSeverityDescription: ").Append(StatusSeverityDescription).Append("\n");
      sb.Append("  Bounds: ").Append(Bounds).Append("\n");
      sb.Append("  Envelope: ").Append(Envelope).Append("\n");
      sb.Append("  StatusAggregationStartDate: ").Append(StatusAggregationStartDate).Append("\n");
      sb.Append("  StatusAggregationEndDate: ").Append(StatusAggregationEndDate).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
