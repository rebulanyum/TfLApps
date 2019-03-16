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
  public class TflApiPresentationEntitiesDisruptedPoint {
    /// <summary>
    /// Gets or Sets AtcoCode
    /// </summary>
    [DataMember(Name="atcoCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "atcoCode")]
    public string AtcoCode { get; set; }

    /// <summary>
    /// Gets or Sets FromDate
    /// </summary>
    [DataMember(Name="fromDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromDate")]
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Gets or Sets ToDate
    /// </summary>
    [DataMember(Name="toDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toDate")]
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets CommonName
    /// </summary>
    [DataMember(Name="commonName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonName")]
    public string CommonName { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Gets or Sets StationAtcoCode
    /// </summary>
    [DataMember(Name="stationAtcoCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationAtcoCode")]
    public string StationAtcoCode { get; set; }

    /// <summary>
    /// Gets or Sets Appearance
    /// </summary>
    [DataMember(Name="appearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appearance")]
    public string Appearance { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalInformation
    /// </summary>
    [DataMember(Name="additionalInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalInformation")]
    public string AdditionalInformation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesDisruptedPoint {\n");
      sb.Append("  AtcoCode: ").Append(AtcoCode).Append("\n");
      sb.Append("  FromDate: ").Append(FromDate).Append("\n");
      sb.Append("  ToDate: ").Append(ToDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CommonName: ").Append(CommonName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  StationAtcoCode: ").Append(StationAtcoCode).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
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
