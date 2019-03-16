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
  public class TflApiPresentationEntitiesFaresFareBounds {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string Operator { get; set; }

    /// <summary>
    /// Gets or Sets DisplayOrder
    /// </summary>
    [DataMember(Name="displayOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayOrder")]
    public int? DisplayOrder { get; set; }

    /// <summary>
    /// Gets or Sets IsPopularFare
    /// </summary>
    [DataMember(Name="isPopularFare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPopularFare")]
    public bool? IsPopularFare { get; set; }

    /// <summary>
    /// Gets or Sets IsPopularTravelCard
    /// </summary>
    [DataMember(Name="isPopularTravelCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPopularTravelCard")]
    public bool? IsPopularTravelCard { get; set; }

    /// <summary>
    /// Gets or Sets IsTour
    /// </summary>
    [DataMember(Name="isTour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTour")]
    public bool? IsTour { get; set; }

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
      sb.Append("class TflApiPresentationEntitiesFaresFareBounds {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
      sb.Append("  Via: ").Append(Via).Append("\n");
      sb.Append("  RouteCode: ").Append(RouteCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Operator: ").Append(Operator).Append("\n");
      sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
      sb.Append("  IsPopularFare: ").Append(IsPopularFare).Append("\n");
      sb.Append("  IsPopularTravelCard: ").Append(IsPopularTravelCard).Append("\n");
      sb.Append("  IsTour: ").Append(IsTour).Append("\n");
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
