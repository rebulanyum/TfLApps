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
  public class TflApiPresentationEntitiesJourneyPlannerJourneyFare {
    /// <summary>
    /// Gets or Sets TotalCost
    /// </summary>
    [DataMember(Name="totalCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCost")]
    public int? TotalCost { get; set; }

    /// <summary>
    /// Gets or Sets Fares
    /// </summary>
    [DataMember(Name="fares", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fares")]
    public List<TflApiPresentationEntitiesJourneyPlannerFare> Fares { get; set; }

    /// <summary>
    /// Gets or Sets Caveats
    /// </summary>
    [DataMember(Name="caveats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "caveats")]
    public List<TflApiPresentationEntitiesJourneyPlannerFareCaveat> Caveats { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerJourneyFare {\n");
      sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
      sb.Append("  Fares: ").Append(Fares).Append("\n");
      sb.Append("  Caveats: ").Append(Caveats).Append("\n");
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
