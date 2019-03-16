using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// Represents a disruption to a route within the transport network.
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesDisruption {
    /// <summary>
    /// Gets or sets the category of this dispruption.
    /// </summary>
    /// <value>Gets or sets the category of this dispruption.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or sets the disruption type of this dispruption.
    /// </summary>
    /// <value>Gets or sets the disruption type of this dispruption.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the description of the category.
    /// </summary>
    /// <value>Gets or sets the description of the category.</value>
    [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryDescription")]
    public string CategoryDescription { get; set; }

    /// <summary>
    /// Gets or sets the description of this disruption.
    /// </summary>
    /// <value>Gets or sets the description of this disruption.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the summary of this disruption.
    /// </summary>
    /// <value>Gets or sets the summary of this disruption.</value>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or sets the additionaInfo of this disruption.
    /// </summary>
    /// <value>Gets or sets the additionaInfo of this disruption.</value>
    [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalInfo")]
    public string AdditionalInfo { get; set; }

    /// <summary>
    /// Gets or sets the date/time when this disruption was created.
    /// </summary>
    /// <value>Gets or sets the date/time when this disruption was created.</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Gets or sets the date/time when this disruption was last updated.
    /// </summary>
    /// <value>Gets or sets the date/time when this disruption was last updated.</value>
    [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdate")]
    public DateTime? LastUpdate { get; set; }

    /// <summary>
    /// Gets or sets the routes affected by this disruption
    /// </summary>
    /// <value>Gets or sets the routes affected by this disruption</value>
    [DataMember(Name="affectedRoutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectedRoutes")]
    public List<TflApiPresentationEntitiesRouteSection> AffectedRoutes { get; set; }

    /// <summary>
    /// Gets or sets the stops affected by this disruption
    /// </summary>
    /// <value>Gets or sets the stops affected by this disruption</value>
    [DataMember(Name="affectedStops", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectedStops")]
    public List<TflApiPresentationEntitiesStopPoint> AffectedStops { get; set; }

    /// <summary>
    /// Text describing the closure type
    /// </summary>
    /// <value>Text describing the closure type</value>
    [DataMember(Name="closureText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closureText")]
    public string ClosureText { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesDisruption {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
      sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
      sb.Append("  AffectedRoutes: ").Append(AffectedRoutes).Append("\n");
      sb.Append("  AffectedStops: ").Append(AffectedStops).Append("\n");
      sb.Append("  ClosureText: ").Append(ClosureText).Append("\n");
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
