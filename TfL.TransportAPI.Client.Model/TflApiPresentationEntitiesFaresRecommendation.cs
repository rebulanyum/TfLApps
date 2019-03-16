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
  public class TflApiPresentationEntitiesFaresRecommendation {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Rule
    /// </summary>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public int? Rule { get; set; }

    /// <summary>
    /// Gets or Sets Rank
    /// </summary>
    [DataMember(Name="rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rank")]
    public int? Rank { get; set; }

    /// <summary>
    /// Gets or Sets FareType
    /// </summary>
    [DataMember(Name="fareType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fareType")]
    public string FareType { get; set; }

    /// <summary>
    /// Gets or Sets Product
    /// </summary>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public string Product { get; set; }

    /// <summary>
    /// Gets or Sets TicketType
    /// </summary>
    [DataMember(Name="ticketType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketType")]
    public string TicketType { get; set; }

    /// <summary>
    /// Gets or Sets TicketTime
    /// </summary>
    [DataMember(Name="ticketTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketTime")]
    public string TicketTime { get; set; }

    /// <summary>
    /// Gets or Sets ProductType
    /// </summary>
    [DataMember(Name="productType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productType")]
    public string ProductType { get; set; }

    /// <summary>
    /// Gets or Sets DiscountCard
    /// </summary>
    [DataMember(Name="discountCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountCard")]
    public string DiscountCard { get; set; }

    /// <summary>
    /// Gets or Sets Zones
    /// </summary>
    [DataMember(Name="zones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zones")]
    public string Zones { get; set; }

    /// <summary>
    /// Gets or Sets Cost
    /// </summary>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public string Cost { get; set; }

    /// <summary>
    /// Gets or Sets PriceDescription
    /// </summary>
    [DataMember(Name="priceDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceDescription")]
    public string PriceDescription { get; set; }

    /// <summary>
    /// Gets or Sets PriceComparison
    /// </summary>
    [DataMember(Name="priceComparison", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceComparison")]
    public string PriceComparison { get; set; }

    /// <summary>
    /// Gets or Sets RecommendedTopUp
    /// </summary>
    [DataMember(Name="recommendedTopUp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendedTopUp")]
    public string RecommendedTopUp { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public List<TflApiPresentationEntitiesMessage> Notes { get; set; }

    /// <summary>
    /// Gets or Sets KeyFeatures
    /// </summary>
    [DataMember(Name="keyFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keyFeatures")]
    public List<TflApiPresentationEntitiesMessage> KeyFeatures { get; set; }

    /// <summary>
    /// Gets or Sets GettingYourTicket
    /// </summary>
    [DataMember(Name="gettingYourTicket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gettingYourTicket")]
    public List<TflApiPresentationEntitiesMessage> GettingYourTicket { get; set; }

    /// <summary>
    /// Gets or Sets SingleFare
    /// </summary>
    [DataMember(Name="singleFare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleFare")]
    public double? SingleFare { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesFaresRecommendation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Rule: ").Append(Rule).Append("\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
      sb.Append("  FareType: ").Append(FareType).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  TicketType: ").Append(TicketType).Append("\n");
      sb.Append("  TicketTime: ").Append(TicketTime).Append("\n");
      sb.Append("  ProductType: ").Append(ProductType).Append("\n");
      sb.Append("  DiscountCard: ").Append(DiscountCard).Append("\n");
      sb.Append("  Zones: ").Append(Zones).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  PriceDescription: ").Append(PriceDescription).Append("\n");
      sb.Append("  PriceComparison: ").Append(PriceComparison).Append("\n");
      sb.Append("  RecommendedTopUp: ").Append(RecommendedTopUp).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  KeyFeatures: ").Append(KeyFeatures).Append("\n");
      sb.Append("  GettingYourTicket: ").Append(GettingYourTicket).Append("\n");
      sb.Append("  SingleFare: ").Append(SingleFare).Append("\n");
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
