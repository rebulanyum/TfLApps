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
  public class TflApiPresentationEntitiesJourneyPlannerTimeAdjustments {
    /// <summary>
    /// Gets or Sets Earliest
    /// </summary>
    [DataMember(Name="earliest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliest")]
    public TflApiPresentationEntitiesJourneyPlannerTimeAdjustment Earliest { get; set; }

    /// <summary>
    /// Gets or Sets Earlier
    /// </summary>
    [DataMember(Name="earlier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earlier")]
    public TflApiPresentationEntitiesJourneyPlannerTimeAdjustment Earlier { get; set; }

    /// <summary>
    /// Gets or Sets Later
    /// </summary>
    [DataMember(Name="later", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "later")]
    public TflApiPresentationEntitiesJourneyPlannerTimeAdjustment Later { get; set; }

    /// <summary>
    /// Gets or Sets Latest
    /// </summary>
    [DataMember(Name="latest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest")]
    public TflApiPresentationEntitiesJourneyPlannerTimeAdjustment Latest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerTimeAdjustments {\n");
      sb.Append("  Earliest: ").Append(Earliest).Append("\n");
      sb.Append("  Earlier: ").Append(Earlier).Append("\n");
      sb.Append("  Later: ").Append(Later).Append("\n");
      sb.Append("  Latest: ").Append(Latest).Append("\n");
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
