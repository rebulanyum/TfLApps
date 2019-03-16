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
  public class TflApiPresentationEntitiesCrowding {
    /// <summary>
    /// Busiest times at a station (static information)
    /// </summary>
    /// <value>Busiest times at a station (static information)</value>
    [DataMember(Name="passengerFlows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerFlows")]
    public List<TflApiPresentationEntitiesPassengerFlow> PassengerFlows { get; set; }

    /// <summary>
    /// Train Loading on a scale 1-6, 1 being \"Very quiet\" and 6 being \"Exceptionally busy\" (static information)
    /// </summary>
    /// <value>Train Loading on a scale 1-6, 1 being \"Very quiet\" and 6 being \"Exceptionally busy\" (static information)</value>
    [DataMember(Name="trainLoadings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trainLoadings")]
    public List<TflApiPresentationEntitiesTrainLoading> TrainLoadings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesCrowding {\n");
      sb.Append("  PassengerFlows: ").Append(PassengerFlows).Append("\n");
      sb.Append("  TrainLoadings: ").Append(TrainLoadings).Append("\n");
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
