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
  public class TflApiPresentationEntitiesRoadDisruption {
    /// <summary>
    /// Unique identifier for the road disruption
    /// </summary>
    /// <value>Unique identifier for the road disruption</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// URL to retrieve this road disruption
    /// </summary>
    /// <value>URL to retrieve this road disruption</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Latitude and longitude (WGS84) of the centroid of the disruption, stored in a geoJSON-formatted string.
    /// </summary>
    /// <value>Latitude and longitude (WGS84) of the centroid of the disruption, stored in a geoJSON-formatted string.</value>
    [DataMember(Name="point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "point")]
    public string Point { get; set; }

    /// <summary>
    /// A description of the severity of the disruption.
    /// </summary>
    /// <value>A description of the severity of the disruption.</value>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    /// <summary>
    /// An ordinal of the disruption based on severity, level of interest and corridor.
    /// </summary>
    /// <value>An ordinal of the disruption based on severity, level of interest and corridor.</value>
    [DataMember(Name="ordinal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordinal")]
    public int? Ordinal { get; set; }

    /// <summary>
    /// Describes the nature of disruption e.g. Traffic Incidents, Works
    /// </summary>
    /// <value>Describes the nature of disruption e.g. Traffic Incidents, Works</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Describes the sub-category of disruption e.g. Collapsed Manhole, Abnormal Load
    /// </summary>
    /// <value>Describes the sub-category of disruption e.g. Collapsed Manhole, Abnormal Load</value>
    [DataMember(Name="subCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subCategory")]
    public string SubCategory { get; set; }

    /// <summary>
    /// Full text of comments describing the disruption, including details of any road closures and diversions, where appropriate.
    /// </summary>
    /// <value>Full text of comments describing the disruption, including details of any road closures and diversions, where appropriate.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public string Comments { get; set; }

    /// <summary>
    /// Text of the most recent update from the LSTCC on the state of the               disruption, including the current traffic impact and any advice to               road users.
    /// </summary>
    /// <value>Text of the most recent update from the LSTCC on the state of the               disruption, including the current traffic impact and any advice to               road users.</value>
    [DataMember(Name="currentUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUpdate")]
    public string CurrentUpdate { get; set; }

    /// <summary>
    /// The time when the last CurrentUpdate description was recorded,               or null if no CurrentUpdate has been applied.
    /// </summary>
    /// <value>The time when the last CurrentUpdate description was recorded,               or null if no CurrentUpdate has been applied.</value>
    [DataMember(Name="currentUpdateDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUpdateDateTime")]
    public DateTime? CurrentUpdateDateTime { get; set; }

    /// <summary>
    /// The Ids of affected corridors, if any.
    /// </summary>
    /// <value>The Ids of affected corridors, if any.</value>
    [DataMember(Name="corridorIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corridorIds")]
    public List<string> CorridorIds { get; set; }

    /// <summary>
    /// The date and time which the disruption started. For a planned disruption (i.e. planned road works) this date will be in the future.              For unplanned disruptions, this will default to the date on which the disruption was first recorded, but may be adjusted by the operator.
    /// </summary>
    /// <value>The date and time which the disruption started. For a planned disruption (i.e. planned road works) this date will be in the future.              For unplanned disruptions, this will default to the date on which the disruption was first recorded, but may be adjusted by the operator.</value>
    [DataMember(Name="startDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDateTime")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// The date and time on which the disruption ended. For planned disruptions, this date will have a valid value. For unplanned               disruptions in progress, this field will be omitted.
    /// </summary>
    /// <value>The date and time on which the disruption ended. For planned disruptions, this date will have a valid value. For unplanned               disruptions in progress, this field will be omitted.</value>
    [DataMember(Name="endDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDateTime")]
    public DateTime? EndDateTime { get; set; }

    /// <summary>
    /// The date and time on which the disruption was last modified in the system. This information can reliably be used by a developer to quickly              compare two instances of the same disruption to determine if it has been changed.
    /// </summary>
    /// <value>The date and time on which the disruption was last modified in the system. This information can reliably be used by a developer to quickly              compare two instances of the same disruption to determine if it has been changed.</value>
    [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// This describes the level of potential impact on traffic operations of the disruption.               High = e.g. a one-off disruption on a major or high profile route which will require a high level of operational attention               Medium = This is the default value               Low = e.g. a frequently occurring disruption which is well known
    /// </summary>
    /// <value>This describes the level of potential impact on traffic operations of the disruption.               High = e.g. a one-off disruption on a major or high profile route which will require a high level of operational attention               Medium = This is the default value               Low = e.g. a frequently occurring disruption which is well known</value>
    [DataMember(Name="levelOfInterest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "levelOfInterest")]
    public string LevelOfInterest { get; set; }

    /// <summary>
    /// Main road name / number (borough) or preset area name where the disruption is located. This might be useful for a map popup where space is limited.
    /// </summary>
    /// <value>Main road name / number (borough) or preset area name where the disruption is located. This might be useful for a map popup where space is limited.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// This describes the status of the disruption.                Active = currently in progress               Active Long Term = currently in progress and long term              Scheduled = scheduled to start within the next 180 days              Recurring Works = planned maintenance works that follow a regular routine or pattern and whose next occurrence is to start within the next 180 days.              Recently Cleared = recently cleared in the last 24 hours              Note that the status of Scheduled or Recurring Works disruptions will change to Active when they start, and will change status again when they end.
    /// </summary>
    /// <value>This describes the status of the disruption.                Active = currently in progress               Active Long Term = currently in progress and long term              Scheduled = scheduled to start within the next 180 days              Recurring Works = planned maintenance works that follow a regular routine or pattern and whose next occurrence is to start within the next 180 days.              Recently Cleared = recently cleared in the last 24 hours              Note that the status of Scheduled or Recurring Works disruptions will change to Active when they start, and will change status again when they end.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Geography version of Point for output as GeoJSON.              Can not use Geometry in a consistent way as non-TIMS disruptions do not have a polygon
    /// </summary>
    /// <value>Geography version of Point for output as GeoJSON.              Can not use Geometry in a consistent way as non-TIMS disruptions do not have a polygon</value>
    [DataMember(Name="geography", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geography")]
    public SystemDataSpatialDbGeography Geography { get; set; }

    /// <summary>
    /// GeoJSON formatted latitude/longitude (WGS84) pairs forming an enclosed polyline or polygon. The polygon will only be included where affected streets information              is not available for the disruption, would be inappropriate (e.g. a very large number of streets), or is centred on an area without streets (e.g. a football stadium).
    /// </summary>
    /// <value>GeoJSON formatted latitude/longitude (WGS84) pairs forming an enclosed polyline or polygon. The polygon will only be included where affected streets information              is not available for the disruption, would be inappropriate (e.g. a very large number of streets), or is centred on an area without streets (e.g. a football stadium).</value>
    [DataMember(Name="geometry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geometry")]
    public SystemDataSpatialDbGeography Geometry { get; set; }

    /// <summary>
    /// A collection of zero or more streets affected by the disruption.
    /// </summary>
    /// <value>A collection of zero or more streets affected by the disruption.</value>
    [DataMember(Name="streets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streets")]
    public List<TflApiPresentationEntitiesStreet> Streets { get; set; }

    /// <summary>
    /// True if the disruption is planned on a future date that is open to change
    /// </summary>
    /// <value>True if the disruption is planned on a future date that is open to change</value>
    [DataMember(Name="isProvisional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isProvisional")]
    public bool? IsProvisional { get; set; }

    /// <summary>
    /// True if any of the affected Streets have a \"Full Closure\" status, false otherwise. A RoadDisruption that has HasClosures is considered a               Severe or Serious disruption for severity filtering purposes.
    /// </summary>
    /// <value>True if any of the affected Streets have a \"Full Closure\" status, false otherwise. A RoadDisruption that has HasClosures is considered a               Severe or Serious disruption for severity filtering purposes.</value>
    [DataMember(Name="hasClosures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasClosures")]
    public bool? HasClosures { get; set; }

    /// <summary>
    /// The text of any associated link
    /// </summary>
    /// <value>The text of any associated link</value>
    [DataMember(Name="linkText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkText")]
    public string LinkText { get; set; }

    /// <summary>
    /// The url of any associated link
    /// </summary>
    /// <value>The url of any associated link</value>
    [DataMember(Name="linkUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkUrl")]
    public string LinkUrl { get; set; }

    /// <summary>
    /// Any associated road project
    /// </summary>
    /// <value>Any associated road project</value>
    [DataMember(Name="roadProject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roadProject")]
    public TflApiPresentationEntitiesRoadProject RoadProject { get; set; }

    /// <summary>
    /// TDM Additional properties
    /// </summary>
    /// <value>TDM Additional properties</value>
    [DataMember(Name="publishStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishStartDate")]
    public DateTime? PublishStartDate { get; set; }

    /// <summary>
    /// Gets or Sets PublishEndDate
    /// </summary>
    [DataMember(Name="publishEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishEndDate")]
    public DateTime? PublishEndDate { get; set; }

    /// <summary>
    /// Gets or Sets TimeFrame
    /// </summary>
    [DataMember(Name="timeFrame", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeFrame")]
    public string TimeFrame { get; set; }

    /// <summary>
    /// Gets or Sets RoadDisruptionLines
    /// </summary>
    [DataMember(Name="roadDisruptionLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roadDisruptionLines")]
    public List<TflApiPresentationEntitiesRoadDisruptionLine> RoadDisruptionLines { get; set; }

    /// <summary>
    /// Gets or Sets RoadDisruptionImpactAreas
    /// </summary>
    [DataMember(Name="roadDisruptionImpactAreas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roadDisruptionImpactAreas")]
    public List<TflApiPresentationEntitiesRoadDisruptionImpactArea> RoadDisruptionImpactAreas { get; set; }

    /// <summary>
    /// Gets or Sets RecurringSchedules
    /// </summary>
    [DataMember(Name="recurringSchedules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringSchedules")]
    public List<TflApiPresentationEntitiesRoadDisruptionSchedule> RecurringSchedules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesRoadDisruption {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Point: ").Append(Point).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  CurrentUpdate: ").Append(CurrentUpdate).Append("\n");
      sb.Append("  CurrentUpdateDateTime: ").Append(CurrentUpdateDateTime).Append("\n");
      sb.Append("  CorridorIds: ").Append(CorridorIds).Append("\n");
      sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
      sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
      sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
      sb.Append("  LevelOfInterest: ").Append(LevelOfInterest).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Geography: ").Append(Geography).Append("\n");
      sb.Append("  Geometry: ").Append(Geometry).Append("\n");
      sb.Append("  Streets: ").Append(Streets).Append("\n");
      sb.Append("  IsProvisional: ").Append(IsProvisional).Append("\n");
      sb.Append("  HasClosures: ").Append(HasClosures).Append("\n");
      sb.Append("  LinkText: ").Append(LinkText).Append("\n");
      sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
      sb.Append("  RoadProject: ").Append(RoadProject).Append("\n");
      sb.Append("  PublishStartDate: ").Append(PublishStartDate).Append("\n");
      sb.Append("  PublishEndDate: ").Append(PublishEndDate).Append("\n");
      sb.Append("  TimeFrame: ").Append(TimeFrame).Append("\n");
      sb.Append("  RoadDisruptionLines: ").Append(RoadDisruptionLines).Append("\n");
      sb.Append("  RoadDisruptionImpactAreas: ").Append(RoadDisruptionImpactAreas).Append("\n");
      sb.Append("  RecurringSchedules: ").Append(RecurringSchedules).Append("\n");
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
