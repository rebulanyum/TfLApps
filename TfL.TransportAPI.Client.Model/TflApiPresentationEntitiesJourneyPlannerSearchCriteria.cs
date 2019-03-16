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
  public class TflApiPresentationEntitiesJourneyPlannerSearchCriteria {
    /// <summary>
    /// Gets or Sets DateTime
    /// </summary>
    [DataMember(Name="dateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateTime")]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Gets or Sets DateTimeType
    /// </summary>
    [DataMember(Name="dateTimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateTimeType")]
    public string DateTimeType { get; set; }

    /// <summary>
    /// Gets or Sets TimeAdjustments
    /// </summary>
    [DataMember(Name="timeAdjustments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeAdjustments")]
    public TflApiPresentationEntitiesJourneyPlannerTimeAdjustments TimeAdjustments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesJourneyPlannerSearchCriteria {\n");
      sb.Append("  DateTime: ").Append(DateTime).Append("\n");
      sb.Append("  DateTimeType: ").Append(DateTimeType).Append("\n");
      sb.Append("  TimeAdjustments: ").Append(TimeAdjustments).Append("\n");
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
