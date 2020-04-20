using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PlantsApp.Models
{
    public class Weather
    {
        public Weather(string json)
        {
            JObject jobject = JObject.Parse(json);
            JToken jtoken = jobject["weather"][0];
            WeatherType = (string)jtoken["main"];
            Description = (string)jtoken["description"];

            JToken jtoken_main = jobject["main"];
            Temperature = (float)jtoken_main["temp"];
            Humidity = (float)jtoken_main["humidity"];
            City = (string)jobject["name"];

        }
        public string WeatherType { get; }
        public string Description { get; }
        public float Temperature { get; }
        public float Humidity { get; }
        public string City { get; }

    }
}