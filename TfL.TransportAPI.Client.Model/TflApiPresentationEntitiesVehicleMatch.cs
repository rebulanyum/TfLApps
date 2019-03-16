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
  public class TflApiPresentationEntitiesVehicleMatch {
    /// <summary>
    /// Gets or Sets Vrm
    /// </summary>
    [DataMember(Name="vrm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vrm")]
    public string Vrm { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Make
    /// </summary>
    [DataMember(Name="make", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "make")]
    public string Make { get; set; }

    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [DataMember(Name="model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "model")]
    public string Model { get; set; }

    /// <summary>
    /// Gets or Sets Colour
    /// </summary>
    [DataMember(Name="colour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colour")]
    public string Colour { get; set; }

    /// <summary>
    /// Gets or Sets Compliance
    /// </summary>
    [DataMember(Name="compliance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compliance")]
    public string Compliance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesVehicleMatch {\n");
      sb.Append("  Vrm: ").Append(Vrm).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Make: ").Append(Make).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Colour: ").Append(Colour).Append("\n");
      sb.Append("  Compliance: ").Append(Compliance).Append("\n");
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
