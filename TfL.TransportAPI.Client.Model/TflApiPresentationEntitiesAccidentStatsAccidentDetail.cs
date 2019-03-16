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
  public class TflApiPresentationEntitiesAccidentStatsAccidentDetail {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Lat
    /// </summary>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// Gets or Sets Lon
    /// </summary>
    [DataMember(Name="lon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lon")]
    public double? Lon { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Gets or Sets Severity
    /// </summary>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public string Severity { get; set; }

    /// <summary>
    /// Gets or Sets Borough
    /// </summary>
    [DataMember(Name="borough", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "borough")]
    public string Borough { get; set; }

    /// <summary>
    /// Gets or Sets Casualties
    /// </summary>
    [DataMember(Name="casualties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "casualties")]
    public List<TflApiPresentationEntitiesAccidentStatsCasualty> Casualties { get; set; }

    /// <summary>
    /// Gets or Sets Vehicles
    /// </summary>
    [DataMember(Name="vehicles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vehicles")]
    public List<TflApiPresentationEntitiesAccidentStatsVehicle> Vehicles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesAccidentStatsAccidentDetail {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      sb.Append("  Lon: ").Append(Lon).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  Borough: ").Append(Borough).Append("\n");
      sb.Append("  Casualties: ").Append(Casualties).Append("\n");
      sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
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
