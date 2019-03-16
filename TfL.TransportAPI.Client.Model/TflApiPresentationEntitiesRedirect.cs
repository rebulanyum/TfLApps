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
  public class TflApiPresentationEntitiesRedirect {
    /// <summary>
    /// Gets or Sets ShortUrl
    /// </summary>
    [DataMember(Name="shortUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortUrl")]
    public string ShortUrl { get; set; }

    /// <summary>
    /// Gets or Sets LongUrl
    /// </summary>
    [DataMember(Name="longUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longUrl")]
    public string LongUrl { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRedirect {\n");
      sb.Append("  ShortUrl: ").Append(ShortUrl).Append("\n");
      sb.Append("  LongUrl: ").Append(LongUrl).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
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
