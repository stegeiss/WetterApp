using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.IO;

namespace WetterAppStandard
{
    class OpenWeatherMapClient
    {
        private OpenWeatherMapResponseParser parser;

        public OpenWeatherMapClient(OpenWeatherMapResponseParser parser)
        {
            this.parser = parser;
        }

        //internal WetterBeschreibung getWetterResponse(string stadt)
        //{
        //    var parsed = JObject.Parse(json);
        //    string modus = "api";
        //    string openweatherURL = "http://" + modus + ".openweathermap.org/data/2.5/weather";
        //    HttpResponse<JsonNode> response = Unirest.get(openweatherURL)
        //        .queryString("q", stadt)
        //        .queryString("appid", weatherAPIKey)
        //        .queryString("lang", "de")
        //        .asJson();
        //    JsonNode body = response.getBody();
        //    HttpUtility
        //    return null;
        //}
    }
}
