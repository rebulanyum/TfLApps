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
  public class TflApiPresentationEntitiesRouteSearchResponse {
    /// <summary>
    /// Gets or Sets Input
    /// </summary>
    [DataMember(Name="input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input")]
    public string Input { get; set; }

    /// <summary>
    /// Gets or Sets SearchMatches
    /// </summary>
    [DataMember(Name="searchMatches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchMatches")]
    public List<TflApiPresentationEntitiesRouteSearchMatch> SearchMatches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRouteSearchResponse {\n");
      sb.Append("  Input: ").Append(Input).Append("\n");
      sb.Append("  SearchMatches: ").Append(SearchMatches).Append("\n");
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
