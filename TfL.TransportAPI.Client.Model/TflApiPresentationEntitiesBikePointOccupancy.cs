using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// Bike point occupancy
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesBikePointOccupancy {
    /// <summary>
    /// Id of the bike point such as BikePoints_1
    /// </summary>
    /// <value>Id of the bike point such as BikePoints_1</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Name / Common name of the bike point
    /// </summary>
    /// <value>Name / Common name of the bike point</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Total bike counts
    /// </summary>
    /// <value>Total bike counts</value>
    [DataMember(Name="bikesCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bikesCount")]
    public int? BikesCount { get; set; }

    /// <summary>
    /// Empty docks
    /// </summary>
    /// <value>Empty docks</value>
    [DataMember(Name="emptyDocks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emptyDocks")]
    public int? EmptyDocks { get; set; }

    /// <summary>
    /// Total docks available
    /// </summary>
    /// <value>Total docks available</value>
    [DataMember(Name="totalDocks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalDocks")]
    public int? TotalDocks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesBikePointOccupancy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  BikesCount: ").Append(BikesCount).Append("\n");
      sb.Append("  EmptyDocks: ").Append(EmptyDocks).Append("\n");
      sb.Append("  TotalDocks: ").Append(TotalDocks).Append("\n");
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
