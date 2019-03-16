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
  public class TflApiPresentationEntitiesRoadProject {
    /// <summary>
    /// Gets or Sets ProjectId
    /// </summary>
    [DataMember(Name="projectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectId")]
    public string ProjectId { get; set; }

    /// <summary>
    /// Gets or Sets SchemeName
    /// </summary>
    [DataMember(Name="schemeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemeName")]
    public string SchemeName { get; set; }

    /// <summary>
    /// Gets or Sets ProjectName
    /// </summary>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Gets or Sets ProjectDescription
    /// </summary>
    [DataMember(Name="projectDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectDescription")]
    public string ProjectDescription { get; set; }

    /// <summary>
    /// Gets or Sets ProjectPageUrl
    /// </summary>
    [DataMember(Name="projectPageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectPageUrl")]
    public string ProjectPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets ConsultationPageUrl
    /// </summary>
    [DataMember(Name="consultationPageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consultationPageUrl")]
    public string ConsultationPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets ConsultationStartDate
    /// </summary>
    [DataMember(Name="consultationStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consultationStartDate")]
    public DateTime? ConsultationStartDate { get; set; }

    /// <summary>
    /// Gets or Sets ConsultationEndDate
    /// </summary>
    [DataMember(Name="consultationEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consultationEndDate")]
    public DateTime? ConsultationEndDate { get; set; }

    /// <summary>
    /// Gets or Sets ConstructionStartDate
    /// </summary>
    [DataMember(Name="constructionStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constructionStartDate")]
    public DateTime? ConstructionStartDate { get; set; }

    /// <summary>
    /// Gets or Sets ConstructionEndDate
    /// </summary>
    [DataMember(Name="constructionEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constructionEndDate")]
    public DateTime? ConstructionEndDate { get; set; }

    /// <summary>
    /// Gets or Sets BoroughsBenefited
    /// </summary>
    [DataMember(Name="boroughsBenefited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boroughsBenefited")]
    public List<string> BoroughsBenefited { get; set; }

    /// <summary>
    /// Gets or Sets CycleSuperhighwayId
    /// </summary>
    [DataMember(Name="cycleSuperhighwayId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cycleSuperhighwayId")]
    public string CycleSuperhighwayId { get; set; }

    /// <summary>
    /// Gets or Sets Phase
    /// </summary>
    [DataMember(Name="phase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phase")]
    public string Phase { get; set; }

    /// <summary>
    /// Gets or Sets ContactName
    /// </summary>
    [DataMember(Name="contactName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contactName")]
    public string ContactName { get; set; }

    /// <summary>
    /// Gets or Sets ContactEmail
    /// </summary>
    [DataMember(Name="contactEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contactEmail")]
    public string ContactEmail { get; set; }

    /// <summary>
    /// Gets or Sets ExternalPageUrl
    /// </summary>
    [DataMember(Name="externalPageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalPageUrl")]
    public string ExternalPageUrl { get; set; }

    /// <summary>
    /// Gets or Sets ProjectSummaryPageUrl
    /// </summary>
    [DataMember(Name="projectSummaryPageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectSummaryPageUrl")]
    public string ProjectSummaryPageUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRoadProject {\n");
      sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
      sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  ProjectDescription: ").Append(ProjectDescription).Append("\n");
      sb.Append("  ProjectPageUrl: ").Append(ProjectPageUrl).Append("\n");
      sb.Append("  ConsultationPageUrl: ").Append(ConsultationPageUrl).Append("\n");
      sb.Append("  ConsultationStartDate: ").Append(ConsultationStartDate).Append("\n");
      sb.Append("  ConsultationEndDate: ").Append(ConsultationEndDate).Append("\n");
      sb.Append("  ConstructionStartDate: ").Append(ConstructionStartDate).Append("\n");
      sb.Append("  ConstructionEndDate: ").Append(ConstructionEndDate).Append("\n");
      sb.Append("  BoroughsBenefited: ").Append(BoroughsBenefited).Append("\n");
      sb.Append("  CycleSuperhighwayId: ").Append(CycleSuperhighwayId).Append("\n");
      sb.Append("  Phase: ").Append(Phase).Append("\n");
      sb.Append("  ContactName: ").Append(ContactName).Append("\n");
      sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
      sb.Append("  ExternalPageUrl: ").Append(ExternalPageUrl).Append("\n");
      sb.Append("  ProjectSummaryPageUrl: ").Append(ProjectSummaryPageUrl).Append("\n");
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
