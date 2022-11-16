using System.Text.Json.Serialization;

public class people
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("height")]
    public string height { get; set; }

     [JsonPropertyName("mass")]
    public string mass { get; set; }

      [JsonPropertyName("hair_color")]
    public string hair_color { get; set; }

      [JsonPropertyName("skin_color")]
    public string skin_color { get; set; }

      [JsonPropertyName("eye_color")]
    public string eye_color { get; set; }

    
      [JsonPropertyName("birth_year")]
    public string birth_year { get; set; }


      [JsonPropertyName("gender")]
    public string gender { get; set; }



    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }
}