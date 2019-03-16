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
  public class TflApiPresentationEntitiesPlace {
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
      sb.Append("class TflApiPresentationEntitiesPlace {\n");
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
