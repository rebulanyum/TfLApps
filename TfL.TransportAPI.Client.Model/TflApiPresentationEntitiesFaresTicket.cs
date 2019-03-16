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
  public class TflApiPresentationEntitiesFaresTicket {
    /// <summary>
    /// Gets or Sets PassengerType
    /// </summary>
    [DataMember(Name="passengerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerType")]
    public string PassengerType { get; set; }

    /// <summary>
    /// Gets or Sets TicketType
    /// </summary>
    [DataMember(Name="ticketType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketType")]
    public TflApiPresentationEntitiesFaresTicketType TicketType { get; set; }

    /// <summary>
    /// Gets or Sets TicketTime
    /// </summary>
    [DataMember(Name="ticketTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketTime")]
    public TflApiPresentationEntitiesFaresTicketTime TicketTime { get; set; }

    /// <summary>
    /// Gets or Sets Cost
    /// </summary>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public string Cost { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets DisplayOrder
    /// </summary>
    [DataMember(Name="displayOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayOrder")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messages")]
    public List<TflApiPresentationEntitiesMessage> Messages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesFaresTicket {\n");
      sb.Append("  PassengerType: ").Append(PassengerType).Append("\n");
      sb.Append("  TicketType: ").Append(TicketType).Append("\n");
      sb.Append("  TicketTime: ").Append(TicketTime).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
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
