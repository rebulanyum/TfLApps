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
  public class TflApiPresentationEntitiesStopPoint {
    /// <summary>
    /// Gets or Sets NaptanId
    /// </summary>
    [DataMember(Name="naptanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanId")]
    public string NaptanId { get; set; }

    /// <summary>
    /// Gets or Sets PlatformName
    /// </summary>
    [DataMember(Name="platformName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformName")]
    public string PlatformName { get; set; }

    /// <summary>
    /// The indicator of the stop point e.g. \"Stop K\"
    /// </summary>
    /// <value>The indicator of the stop point e.g. \"Stop K\"</value>
    [DataMember(Name="indicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indicator")]
    public string Indicator { get; set; }

    /// <summary>
    /// The stop letter, if it could be cleansed from the Indicator e.g. \"K\"
    /// </summary>
    /// <value>The stop letter, if it could be cleansed from the Indicator e.g. \"K\"</value>
    [DataMember(Name="stopLetter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLetter")]
    public string StopLetter { get; set; }

    /// <summary>
    /// Gets or Sets Modes
    /// </summary>
    [DataMember(Name="modes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modes")]
    public List<string> Modes { get; set; }

    /// <summary>
    /// Gets or Sets IcsCode
    /// </summary>
    [DataMember(Name="icsCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icsCode")]
    public string IcsCode { get; set; }

    /// <summary>
    /// Gets or Sets SmsCode
    /// </summary>
    [DataMember(Name="smsCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smsCode")]
    public string SmsCode { get; set; }

    /// <summary>
    /// Gets or Sets StopType
    /// </summary>
    [DataMember(Name="stopType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopType")]
    public string StopType { get; set; }

    /// <summary>
    /// Gets or Sets StationNaptan
    /// </summary>
    [DataMember(Name="stationNaptan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationNaptan")]
    public string StationNaptan { get; set; }

    /// <summary>
    /// Gets or Sets AccessibilitySummary
    /// </summary>
    [DataMember(Name="accessibilitySummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessibilitySummary")]
    public string AccessibilitySummary { get; set; }

    /// <summary>
    /// Gets or Sets HubNaptanCode
    /// </summary>
    [DataMember(Name="hubNaptanCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hubNaptanCode")]
    public string HubNaptanCode { get; set; }

    /// <summary>
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lines")]
    public List<TflApiPresentationEntitiesIdentifier> Lines { get; set; }

    /// <summary>
    /// Gets or Sets LineGroup
    /// </summary>
    [DataMember(Name="lineGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineGroup")]
    public List<TflApiPresentationEntitiesLineGroup> LineGroup { get; set; }

    /// <summary>
    /// Gets or Sets LineModeGroups
    /// </summary>
    [DataMember(Name="lineModeGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineModeGroups")]
    public List<TflApiPresentationEntitiesLineModeGroup> LineModeGroups { get; set; }

    /// <summary>
    /// Gets or Sets FullName
    /// </summary>
    [DataMember(Name="fullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullName")]
    public string FullName { get; set; }

    /// <summary>
    /// Gets or Sets NaptanMode
    /// </summary>
    [DataMember(Name="naptanMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanMode")]
    public string NaptanMode { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public bool? Status { get; set; }

    /// <summary>
    /// A unique identifier.
    /// </summary>
    /// <value>A unique identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The unique location of this resource.
    /// </summary>
    /// <value>The unique location of this resource.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// A human readable name.
    /// </summary>
    /// <value>A human readable name.</value>
    [DataMember(Name="commonName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonName")]
    public string CommonName { get; set; }

    /// <summary>
    /// The distance of the place from its search point, if this is the result              of a geographical search, otherwise zero.
    /// </summary>
    /// <value>The distance of the place from its search point, if this is the result              of a geographical search, otherwise zero.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public double? Distance { get; set; }

    /// <summary>
    /// The type of Place. See /Place/Meta/placeTypes for possible values.
    /// </summary>
    /// <value>The type of Place. See /Place/Meta/placeTypes for possible values.</value>
    [DataMember(Name="placeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placeType")]
    public string PlaceType { get; set; }

    /// <summary>
    /// A bag of additional key/value pairs with extra information about this place.
    /// </summary>
    /// <value>A bag of additional key/value pairs with extra information about this place.</value>
    [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalProperties")]
    public List<TflApiPresentationEntitiesAdditionalProperties> AdditionalProperties { get; set; }

    /// <summary>
    /// Gets or Sets Children
    /// </summary>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<TflApiPresentationEntitiesPlace> Children { get; set; }

    /// <summary>
    /// Gets or Sets ChildrenUrls
    /// </summary>
    [DataMember(Name="childrenUrls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childrenUrls")]
    public List<string> ChildrenUrls { get; set; }

    /// <summary>
    /// WGS84 latitude of the location.
    /// </summary>
    /// <value>WGS84 latitude of the location.</value>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// WGS84 longitude of the location.
    /// </summary>
    /// <value>WGS84 longitude of the location.</value>
    [DataMember(Name="lon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lon")]
    public double? Lon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesStopPoint {\n");
      sb.Append("  NaptanId: ").Append(NaptanId).Append("\n");
      sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
      sb.Append("  Indicator: ").Append(Indicator).Append("\n");
      sb.Append("  StopLetter: ").Append(StopLetter).Append("\n");
      sb.Append("  Modes: ").Append(Modes).Append("\n");
      sb.Append("  IcsCode: ").Append(IcsCode).Append("\n");
      sb.Append("  SmsCode: ").Append(SmsCode).Append("\n");
      sb.Append("  StopType: ").Append(StopType).Append("\n");
      sb.Append("  StationNaptan: ").Append(StationNaptan).Append("\n");
      sb.Append("  AccessibilitySummary: ").Append(AccessibilitySummary).Append("\n");
      sb.Append("  HubNaptanCode: ").Append(HubNaptanCode).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
      sb.Append("  LineGroup: ").Append(LineGroup).Append("\n");
      sb.Append("  LineModeGroups: ").Append(LineModeGroups).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  NaptanMode: ").Append(NaptanMode).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  CommonName: ").Append(CommonName).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  PlaceType: ").Append(PlaceType).Append("\n");
      sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  ChildrenUrls: ").Append(ChildrenUrls).Append("\n");
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      sb.Append("  Lon: ").Append(Lon).Append("\n");
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
