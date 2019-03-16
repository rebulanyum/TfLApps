using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// A paged response containing StopPoints
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesStopPointsResponse {
    /// <summary>
    /// The centre latitude/longitude of this list of StopPoints
    /// </summary>
    /// <value>The centre latitude/longitude of this list of StopPoints</value>
    [DataMember(Name="centrePoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "centrePoint")]
    public List<double?> CentrePoint { get; set; }

    /// <summary>
    /// Collection of stop points
    /// </summary>
    /// <value>Collection of stop points</value>
    [DataMember(Name="stopPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopPoints")]
    public List<TflApiPresentationEntitiesStopPoint> StopPoints { get; set; }

    /// <summary>
    /// The maximum size of the page in this response i.e. the maximum number of StopPoints
    /// </summary>
    /// <value>The maximum size of the page in this response i.e. the maximum number of StopPoints</value>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// The total number of StopPoints available across all pages
    /// </summary>
    /// <value>The total number of StopPoints available across all pages</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// The index of this page
    /// </summary>
    /// <value>The index of this page</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStopPointsResponse {\n");
      sb.Append("  CentrePoint: ").Append(CentrePoint).Append("\n");
      sb.Append("  StopPoints: ").Append(StopPoints).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
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
