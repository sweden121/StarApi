using RestSharp;
using System.Text.Json;
using System.Net;
RestClient swapiClient = new("https://swapi.py4e.com/api/");
RestRequest request = new("people/4/");
RestResponse response = swapiClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
  people p = JsonSerializer.Deserialize<people>(response.Content);
  Console.WriteLine(p.Name);
  Console.WriteLine(p.height);
  Console.WriteLine(p.mass);
  Console.WriteLine(p.hair_color);
  Console.WriteLine(p.skin_color);
  Console.WriteLine(p.eye_color);
  Console.WriteLine(p.birth_year);
  Console.WriteLine(p.gender);
}
else
{
  Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();