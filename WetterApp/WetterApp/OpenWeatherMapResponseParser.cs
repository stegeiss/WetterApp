using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
{
    class OpenWeatherMapResponseParser
    {
        public string ParseBeschreibung(string body)
        {
            JObject json = JObject.Parse(body);
            string description = json["weather"][0]["description"].ToString();
            return description;
        }

        public string ParseTemperatur(string body)
        {
            JObject json = JObject.Parse(body);
            string temp = json["main"]["temp"].ToString();
            return temp;
        }
    }
}
