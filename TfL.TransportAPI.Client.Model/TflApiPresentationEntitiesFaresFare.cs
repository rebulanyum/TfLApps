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
  public class TflApiPresentationEntitiesFaresFare {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets PassengerType
    /// </summary>
    [DataMember(Name="passengerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerType")]
    public string PassengerType { get; set; }

    /// <summary>
    /// Gets or Sets ValidFrom
    /// </summary>
    [DataMember(Name="validFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validFrom")]
    public DateTime? ValidFrom { get; set; }

    /// <summary>
    /// Gets or Sets ValidUntil
    /// </summary>
    [DataMember(Name="validUntil", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validUntil")]
    public DateTime? ValidUntil { get; set; }

    /// <summary>
    /// Gets or Sets TicketTime
    /// </summary>
    [DataMember(Name="ticketTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketTime")]
    public string TicketTime { get; set; }

    /// <summary>
    /// Gets or Sets TicketType
    /// </summary>
    [DataMember(Name="ticketType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketType")]
    public string TicketType { get; set; }

    /// <summary>
    /// Gets or Sets Cost
    /// </summary>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public string Cost { get; set; }

    /// <summary>
    /// Gets or Sets Cap
    /// </summary>
    [DataMember(Name="cap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cap")]
    public double? Cap { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Zone
    /// </summary>
    [DataMember(Name="zone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zone")]
    public string Zone { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesFaresFare {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PassengerType: ").Append(PassengerType).Append("\n");
      sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
      sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
      sb.Append("  TicketTime: ").Append(TicketTime).Append("\n");
      sb.Append("  TicketType: ").Append(TicketType).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Cap: ").Append(Cap).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Zone: ").Append(Zone).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
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
