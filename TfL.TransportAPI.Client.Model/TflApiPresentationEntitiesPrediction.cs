using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace   TfL.TransportAPI.Client.Model {

  /// <summary>
  /// DTO to capture the prediction details
  /// </summary>
  [DataContract]
  public class TflApiPresentationEntitiesPrediction {
    /// <summary>
    /// The identitier for the prediction
    /// </summary>
    /// <value>The identitier for the prediction</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The type of the operation (1: is new or has been updated, 2: should be deleted from any client cache)
    /// </summary>
    /// <value>The type of the operation (1: is new or has been updated, 2: should be deleted from any client cache)</value>
    [DataMember(Name="operationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operationType")]
    public int? OperationType { get; set; }

    /// <summary>
    /// The actual vehicle in transit (for train modes, the leading car of the rolling set)
    /// </summary>
    /// <value>The actual vehicle in transit (for train modes, the leading car of the rolling set)</value>
    [DataMember(Name="vehicleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vehicleId")]
    public string VehicleId { get; set; }

    /// <summary>
    /// Identifier for the prediction
    /// </summary>
    /// <value>Identifier for the prediction</value>
    [DataMember(Name="naptanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naptanId")]
    public string NaptanId { get; set; }

    /// <summary>
    /// Station name
    /// </summary>
    /// <value>Station name</value>
    [DataMember(Name="stationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stationName")]
    public string StationName { get; set; }

    /// <summary>
    /// Unique identifier for the Line
    /// </summary>
    /// <value>Unique identifier for the Line</value>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId")]
    public string LineId { get; set; }

    /// <summary>
    /// Line Name
    /// </summary>
    /// <value>Line Name</value>
    [DataMember(Name="lineName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineName")]
    public string LineName { get; set; }

    /// <summary>
    /// Platform name (for bus, this is the stop letter)
    /// </summary>
    /// <value>Platform name (for bus, this is the stop letter)</value>
    [DataMember(Name="platformName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformName")]
    public string PlatformName { get; set; }

    /// <summary>
    /// Direction (unified to inbound/outbound)
    /// </summary>
    /// <value>Direction (unified to inbound/outbound)</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    /// <summary>
    /// Bearing (between 0 to 359)
    /// </summary>
    /// <value>Bearing (between 0 to 359)</value>
    [DataMember(Name="bearing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bearing")]
    public string Bearing { get; set; }

    /// <summary>
    /// Naptan Identifier for the prediction's destination
    /// </summary>
    /// <value>Naptan Identifier for the prediction's destination</value>
    [DataMember(Name="destinationNaptanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationNaptanId")]
    public string DestinationNaptanId { get; set; }

    /// <summary>
    /// Name of the destination
    /// </summary>
    /// <value>Name of the destination</value>
    [DataMember(Name="destinationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationName")]
    public string DestinationName { get; set; }

    /// <summary>
    /// Timestamp for when the prediction was inserted/modified (source column drives what objects are broadcast on each iteration)
    /// </summary>
    /// <value>Timestamp for when the prediction was inserted/modified (source column drives what objects are broadcast on each iteration)</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Prediction of the Time to station in seconds
    /// </summary>
    /// <value>Prediction of the Time to station in seconds</value>
    [DataMember(Name="timeToStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToStation")]
    public int? TimeToStation { get; set; }

    /// <summary>
    /// The current location of the vehicle.
    /// </summary>
    /// <value>The current location of the vehicle.</value>
    [DataMember(Name="currentLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentLocation")]
    public string CurrentLocation { get; set; }

    /// <summary>
    /// Routing information or other descriptive text about the path of the vehicle towards the destination
    /// </summary>
    /// <value>Routing information or other descriptive text about the path of the vehicle towards the destination</value>
    [DataMember(Name="towards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "towards")]
    public string Towards { get; set; }

    /// <summary>
    /// The expected arrival time of the vehicle at the stop/station
    /// </summary>
    /// <value>The expected arrival time of the vehicle at the stop/station</value>
    [DataMember(Name="expectedArrival", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expectedArrival")]
    public DateTime? ExpectedArrival { get; set; }

    /// <summary>
    /// The expiry time for the prediction
    /// </summary>
    /// <value>The expiry time for the prediction</value>
    [DataMember(Name="timeToLive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToLive")]
    public DateTime? TimeToLive { get; set; }

    /// <summary>
    /// The mode name of the station/line the prediction relates to
    /// </summary>
    /// <value>The mode name of the station/line the prediction relates to</value>
    [DataMember(Name="modeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modeName")]
    public string ModeName { get; set; }

    /// <summary>
    /// Keep the original timestamp from MongoDb fo debugging purposes
    /// </summary>
    /// <value>Keep the original timestamp from MongoDb fo debugging purposes</value>
    [DataMember(Name="timing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timing")]
    public TflApiPresentationEntitiesPredictionTiming Timing { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesPrediction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OperationType: ").Append(OperationType).Append("\n");
      sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
      sb.Append("  NaptanId: ").Append(NaptanId).Append("\n");
      sb.Append("  StationName: ").Append(StationName).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
      sb.Append("  LineName: ").Append(LineName).Append("\n");
      sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Bearing: ").Append(Bearing).Append("\n");
      sb.Append("  DestinationNaptanId: ").Append(DestinationNaptanId).Append("\n");
      sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  TimeToStation: ").Append(TimeToStation).Append("\n");
      sb.Append("  CurrentLocation: ").Append(CurrentLocation).Append("\n");
      sb.Append("  Towards: ").Append(Towards).Append("\n");
      sb.Append("  ExpectedArrival: ").Append(ExpectedArrival).Append("\n");
      sb.Append("  TimeToLive: ").Append(TimeToLive).Append("\n");
      sb.Append("  ModeName: ").Append(ModeName).Append("\n");
      sb.Append("  Timing: ").Append(Timing).Append("\n");
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
