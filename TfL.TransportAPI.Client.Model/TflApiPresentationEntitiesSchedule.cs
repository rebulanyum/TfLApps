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
  public class TflApiPresentationEntitiesSchedule {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets KnownJourneys
    /// </summary>
    [DataMember(Name="knownJourneys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "knownJourneys")]
    public List<TflApiPresentationEntitiesKnownJourney> KnownJourneys { get; set; }

    /// <summary>
    /// Gets or Sets FirstJourney
    /// </summary>
    [DataMember(Name="firstJourney", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstJourney")]
    public TflApiPresentationEntitiesKnownJourney FirstJourney { get; set; }

    /// <summary>
    /// Gets or Sets LastJourney
    /// </summary>
    [DataMember(Name="lastJourney", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastJourney")]
    public TflApiPresentationEntitiesKnownJourney LastJourney { get; set; }

    /// <summary>
    /// Gets or Sets Periods
    /// </summary>
    [DataMember(Name="periods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periods")]
    public List<TflApiPresentationEntitiesPeriod> Periods { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TflApiPresentationEntitiesSchedule {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  KnownJourneys: ").Append(KnownJourneys).Append("\n");
      sb.Append("  FirstJourney: ").Append(FirstJourney).Append("\n");
      sb.Append("  LastJourney: ").Append(LastJourney).Append("\n");
      sb.Append("  Periods: ").Append(Periods).Append("\n");
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
