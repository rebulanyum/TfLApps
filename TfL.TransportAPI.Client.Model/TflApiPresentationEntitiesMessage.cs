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
  public class TflApiPresentationEntitiesMessage {
    /// <summary>
    /// Gets or Sets BulletOrder
    /// </summary>
    [DataMember(Name="bulletOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulletOrder")]
    public int? BulletOrder { get; set; }

    /// <summary>
    /// Gets or Sets Header
    /// </summary>
    [DataMember(Name="header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header")]
    public bool? Header { get; set; }

    /// <summary>
    /// Gets or Sets MessageText
    /// </summary>
    [DataMember(Name="messageText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageText")]
    public string MessageText { get; set; }

    /// <summary>
    /// Gets or Sets LinkText
    /// </summary>
    [DataMember(Name="linkText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkText")]
    public string LinkText { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesMessage {\n");
      sb.Append("  BulletOrder: ").Append(BulletOrder).Append("\n");
      sb.Append("  Header: ").Append(Header).Append("\n");
      sb.Append("  MessageText: ").Append(MessageText).Append("\n");
      sb.Append("  LinkText: ").Append(LinkText).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
