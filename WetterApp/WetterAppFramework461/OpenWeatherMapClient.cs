using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;

namespace WetterAppFramework461
{
    class OpenWeatherMapClient
    {
        private OpenWeatherMapResponseParser parser;

        public OpenWeatherMapClient(OpenWeatherMapResponseParser parser)
        {
            this.parser = parser;
        }

        internal WetterBeschreibung getWetterResponse(string stadt)
        {
            //string modus = "api";
            //string openweatherURL = "http://" + modus + ".openweathermap.org/data/2.5/weather";
            //httpResponse<JsonNode> response = Unirest.get(openweatherURL)
            //    .queryString("q", stadt)
            //    .queryString("appid", weatherAPIKey)
            //    .queryString("lang", "de")
            //    .asJson();
            //JsonNode body = response.getBody();
           
            
            return null;
        }
    }
}
