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
  public class TflApiPresentationEntitiesTimetableResponse {
    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Gets or Sets LineName
    /// </summary>
    [DataMember(Name="lineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineName")]
    public string LineName { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Gets or Sets PdfUrl
    /// </summary>
    [DataMember(Name="pdfUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pdfUrl")]
    public string PdfUrl { get; set; }

    /// <summary>
    /// Gets or Sets Stations
    /// </summary>
    [DataMember(Name="stations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stations")]
    public List<TflApiPresentationEntitiesMatchedStop> Stations { get; set; }

    /// <summary>
    /// Gets or Sets Stops
    /// </summary>
    [DataMember(Name="stops", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stops")]
    public List<TflApiPresentationEntitiesMatchedStop> Stops { get; set; }

    /// <summary>
    /// Gets or Sets Timetable
    /// </summary>
    [DataMember(Name="timetable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timetable")]
    public TflApiPresentationEntitiesTimetable Timetable { get; set; }

    /// <summary>
    /// Gets or Sets Disambiguation
    /// </summary>
    [DataMember(Name="disambiguation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disambiguation")]
    public TflApiPresentationEntitiesTimetablesDisambiguation Disambiguation { get; set; }

    /// <summary>
    /// Gets or Sets StatusErrorMessage
    /// </summary>
    [DataMember(Name="statusErrorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusErrorMessage")]
    public string StatusErrorMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesTimetableResponse {\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  PdfUrl: ").Append(PdfUrl).Append("\n");
      sb.Append("  Stations: ").Append(Stations).Append("\n");
      sb.Append("  Stops: ").Append(Stops).Append("\n");
      sb.Append("  Timetable: ").Append(Timetable).Append("\n");
      sb.Append("  Disambiguation: ").Append(Disambiguation).Append("\n");
      sb.Append("  StatusErrorMessage: ").Append(StatusErrorMessage).Append("\n");
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
