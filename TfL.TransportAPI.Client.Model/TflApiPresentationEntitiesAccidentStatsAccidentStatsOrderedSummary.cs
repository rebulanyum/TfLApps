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
  public class TflApiPresentationEntitiesAccidentStatsAccidentStatsOrderedSummary {
    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }

    /// <summary>
    /// Gets or Sets Borough
    /// </summary>
    [DataMember(Name="borough", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borough")]
    public string Borough { get; set; }

    /// <summary>
    /// Gets or Sets Accidents
    /// </summary>
    [DataMember(Name="accidents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accidents")]
    public int? Accidents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesAccidentStatsAccidentStatsOrderedSummary {\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  Borough: ").Append(Borough).Append("\n");
      sb.Append("  Accidents: ").Append(Accidents).Append("\n");
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
