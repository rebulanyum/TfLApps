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
  public class TflApiPresentationEntitiesJourneyPlannerFareTap {
    /// <summary>
    /// Gets or Sets AtcoCode
    /// </summary>
    [DataMember(Name="atcoCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "atcoCode")]
    public string AtcoCode { get; set; }

    /// <summary>
    /// Gets or Sets TapDetails
    /// </summary>
    [DataMember(Name="tapDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tapDetails")]
    public TflApiPresentationEntitiesJourneyPlannerFareTapDetails TapDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerFareTap {\n");
      sb.Append("  AtcoCode: ").Append(AtcoCode).Append("\n");
      sb.Append("  TapDetails: ").Append(TapDetails).Append("\n");
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
