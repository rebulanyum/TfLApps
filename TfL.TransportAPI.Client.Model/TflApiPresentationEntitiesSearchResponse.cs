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
  public class TflApiPresentationEntitiesSearchResponse {
    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    [DataMember(Name="query", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "query")]
    public string Query { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public int? From { get; set; }

    /// <summary>
    /// Gets or Sets Page
    /// </summary>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [DataMember(Name="provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider")]
    public string Provider { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Gets or Sets Matches
    /// </summary>
    [DataMember(Name="matches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matches")]
    public List<TflApiPresentationEntitiesSearchMatch> Matches { get; set; }

    /// <summary>
    /// Gets or Sets MaxScore
    /// </summary>
    [DataMember(Name="maxScore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxScore")]
    public double? MaxScore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesSearchResponse {\n");
      sb.Append("  Query: ").Append(Query).Append("\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Matches: ").Append(Matches).Append("\n");
      sb.Append("  MaxScore: ").Append(MaxScore).Append("\n");
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
