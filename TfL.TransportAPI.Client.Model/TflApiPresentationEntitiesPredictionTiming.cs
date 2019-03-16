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
  public class TflApiPresentationEntitiesPredictionTiming {
    /// <summary>
    /// Gets or Sets CountdownServerAdjustment
    /// </summary>
    [DataMember(Name="countdownServerAdjustment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countdownServerAdjustment")]
    public string CountdownServerAdjustment { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public DateTime? Source { get; set; }

    /// <summary>
    /// Gets or Sets Insert
    /// </summary>
    [DataMember(Name="insert", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insert")]
    public DateTime? Insert { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [DataMember(Name="read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read")]
    public DateTime? Read { get; set; }

    /// <summary>
    /// Gets or Sets Sent
    /// </summary>
    [DataMember(Name="sent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sent")]
    public DateTime? Sent { get; set; }

    /// <summary>
    /// Gets or Sets Received
    /// </summary>
    [DataMember(Name="received", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "received")]
    public DateTime? Received { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPredictionTiming {\n");
      sb.Append("  CountdownServerAdjustment: ").Append(CountdownServerAdjustment).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Insert: ").Append(Insert).Append("\n");
      sb.Append("  Read: ").Append(Read).Append("\n");
      sb.Append("  Sent: ").Append(Sent).Append("\n");
      sb.Append("  Received: ").Append(Received).Append("\n");
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
