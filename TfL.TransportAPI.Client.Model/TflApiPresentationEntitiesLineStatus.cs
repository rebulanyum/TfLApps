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
  public class TflApiPresentationEntitiesLineStatus {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Gets or Sets StatusSeverity
    /// </summary>
    [DataMember(Name="statusSeverity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusSeverity")]
    public int? StatusSeverity { get; set; }

    /// <summary>
    /// Gets or Sets StatusSeverityDescription
    /// </summary>
    [DataMember(Name="statusSeverityDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusSeverityDescription")]
    public string StatusSeverityDescription { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

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
    /// Gets or Sets ValidityPeriods
    /// </summary>
    [DataMember(Name="validityPeriods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validityPeriods")]
    public List<TflApiPresentationEntitiesValidityPeriod> ValidityPeriods { get; set; }

    /// <summary>
    /// Gets or Sets Disruption
    /// </summary>
    [DataMember(Name="disruption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disruption")]
    public TflApiPresentationEntitiesDisruption Disruption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesLineStatus {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  StatusSeverity: ").Append(StatusSeverity).Append("\n");
      sb.Append("  StatusSeverityDescription: ").Append(StatusSeverityDescription).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Modified: ").Append(Modified).Append("\n");
      sb.Append("  ValidityPeriods: ").Append(ValidityPeriods).Append("\n");
      sb.Append("  Disruption: ").Append(Disruption).Append("\n");
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
