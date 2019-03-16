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
  public class TflApiPresentationEntitiesFaresFareDetails {
    /// <summary>
    /// Gets or Sets BoundsId
    /// </summary>
    [DataMember(Name="boundsId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boundsId")]
    public int? BoundsId { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets PassengerType
    /// </summary>
    [DataMember(Name="passengerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerType")]
    public string PassengerType { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public string From { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public string To { get; set; }

    /// <summary>
    /// Gets or Sets FromStation
    /// </summary>
    [DataMember(Name="fromStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromStation")]
    public string FromStation { get; set; }

    /// <summary>
    /// Gets or Sets ToStation
    /// </summary>
    [DataMember(Name="toStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toStation")]
    public string ToStation { get; set; }

    /// <summary>
    /// Gets or Sets Via
    /// </summary>
    [DataMember(Name="via", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "via")]
    public string Via { get; set; }

    /// <summary>
    /// Gets or Sets RouteCode
    /// </summary>
    [DataMember(Name="routeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeCode")]
    public string RouteCode { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayOrder
    /// </summary>
    [DataMember(Name="displayOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayOrder")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Gets or Sets RouteDescription
    /// </summary>
    [DataMember(Name="routeDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routeDescription")]
    public string RouteDescription { get; set; }

    /// <summary>
    /// Gets or Sets ValidatorInformation
    /// </summary>
    [DataMember(Name="validatorInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validatorInformation")]
    public string ValidatorInformation { get; set; }

    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string Operator { get; set; }

    /// <summary>
    /// Gets or Sets SpecialFare
    /// </summary>
    [DataMember(Name="specialFare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specialFare")]
    public bool? SpecialFare { get; set; }

    /// <summary>
    /// Gets or Sets ThroughFare
    /// </summary>
    [DataMember(Name="throughFare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "throughFare")]
    public bool? ThroughFare { get; set; }

    /// <summary>
    /// Gets or Sets IsTour
    /// </summary>
    [DataMember(Name="isTour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTour")]
    public bool? IsTour { get; set; }

    /// <summary>
    /// Gets or Sets TicketsAvailable
    /// </summary>
    [DataMember(Name="ticketsAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketsAvailable")]
    public List<TflApiPresentationEntitiesFaresTicket> TicketsAvailable { get; set; }

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
      sb.Append("class TflApiPresentationEntitiesFaresFareDetails {\n");
      sb.Append("  BoundsId: ").Append(BoundsId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  PassengerType: ").Append(PassengerType).Append("\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  FromStation: ").Append(FromStation).Append("\n");
      sb.Append("  ToStation: ").Append(ToStation).Append("\n");
      sb.Append("  Via: ").Append(Via).Append("\n");
      sb.Append("  RouteCode: ").Append(RouteCode).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
      sb.Append("  RouteDescription: ").Append(RouteDescription).Append("\n");
      sb.Append("  ValidatorInformation: ").Append(ValidatorInformation).Append("\n");
      sb.Append("  Operator: ").Append(Operator).Append("\n");
      sb.Append("  SpecialFare: ").Append(SpecialFare).Append("\n");
      sb.Append("  ThroughFare: ").Append(ThroughFare).Append("\n");
      sb.Append("  IsTour: ").Append(IsTour).Append("\n");
      sb.Append("  TicketsAvailable: ").Append(TicketsAvailable).Append("\n");
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
