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
  public class TflApiPresentationEntitiesLine {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ModeName
    /// </summary>
    [DataMember(Name="modeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeName")]
    public string ModeName { get; set; }

    /// <summary>
    /// Gets or Sets Disruptions
    /// </summary>
    [DataMember(Name="disruptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disruptions")]
    public List<TflApiPresentationEntitiesDisruption> Disruptions { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Gets or Sets Modified
    /// </summary>
    [DataMember(Name="modified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified")]
    public DateTime? Modified { get; set; }

    /// <summary>
    /// Gets or Sets LineStatuses
    /// </summary>
    [DataMember(Name="lineStatuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineStatuses")]
    public List<TflApiPresentationEntitiesLineStatus> LineStatuses { get; set; }

    /// <summary>
    /// Gets or Sets RouteSections
    /// </summary>
    [DataMember(Name="routeSections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeSections")]
    public List<TflApiPresentationEntitiesMatchedRoute> RouteSections { get; set; }

    /// <summary>
    /// Gets or Sets ServiceTypes
    /// </summary>
    [DataMember(Name="serviceTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceTypes")]
    public List<TflApiPresentationEntitiesLineServiceTypeInfo> ServiceTypes { get; set; }

    /// <summary>
    /// Gets or Sets Crowding
    /// </summary>
    [DataMember(Name="crowding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crowding")]
    public TflApiPresentationEntitiesCrowding Crowding { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLine {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ModeName: ").Append(ModeName).Append("\n");
      sb.Append("  Disruptions: ").Append(Disruptions).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  LineStatuses: ").Append(LineStatuses).Append("\n");
      sb.Append("  RouteSections: ").Append(RouteSections).Append("\n");
      sb.Append("  ServiceTypes: ").Append(ServiceTypes).Append("\n");
      sb.Append("  Crowding: ").Append(Crowding).Append("\n");
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
