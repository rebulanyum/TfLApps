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
  public class TflApiPresentationEntitiesCarParkOccupancy {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Bays
    /// </summary>
    [DataMember(Name="bays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bays")]
    public List<TflApiPresentationEntitiesBay> Bays { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CarParkDetailsUrl
    /// </summary>
    [DataMember(Name="carParkDetailsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carParkDetailsUrl")]
    public string CarParkDetailsUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesCarParkOccupancy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Bays: ").Append(Bays).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CarParkDetailsUrl: ").Append(CarParkDetailsUrl).Append("\n");
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
