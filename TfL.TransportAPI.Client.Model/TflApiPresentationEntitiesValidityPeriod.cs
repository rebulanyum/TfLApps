using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// Represents a period for which a planned works is valid.
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesValidityPeriod {
    /// <summary>
    /// Gets or sets the start date.
    /// </summary>
    /// <value>Gets or sets the start date.</value>
    [DataMember(Name="fromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromDate")]
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Gets or sets the end date.
    /// </summary>
    /// <value>Gets or sets the end date.</value>
    [DataMember(Name="toDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toDate")]
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// If true is a realtime status rather than planned or info
    /// </summary>
    /// <value>If true is a realtime status rather than planned or info</value>
    [DataMember(Name="isNow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isNow")]
    public bool? IsNow { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesValidityPeriod {\n");
      sb.Append("  FromDate: ").Append(FromDate).Append("\n");
      sb.Append("  ToDate: ").Append(ToDate).Append("\n");
      sb.Append("  IsNow: ").Append(IsNow).Append("\n");
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
