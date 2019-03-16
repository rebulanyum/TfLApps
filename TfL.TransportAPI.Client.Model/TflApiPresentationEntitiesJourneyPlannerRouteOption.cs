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
  public class TflApiPresentationEntitiesJourneyPlannerRouteOption {
    /// <summary>
    /// The Id of the route
    /// </summary>
    /// <value>The Id of the route</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name such as \"72\"
    /// </summary>
    /// <value>Name such as \"72\"</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Directions
    /// </summary>
    [DataMember(Name="directions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directions")]
    public List<string> Directions { get; set; }

    /// <summary>
    /// The line identifier (e.g. District Line), from where you can obtain line status information e.g. the rainbow board status \"good service\".
    /// </summary>
    /// <value>The line identifier (e.g. District Line), from where you can obtain line status information e.g. the rainbow board status \"good service\".</value>
    [DataMember(Name="lineIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineIdentifier")]
    public TflApiPresentationEntitiesIdentifier LineIdentifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerRouteOption {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Directions: ").Append(Directions).Append("\n");
      sb.Append("  LineIdentifier: ").Append(LineIdentifier).Append("\n");
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
