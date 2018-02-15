using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace WetterApp
{
    class OpenWeatherMapClient
    {
        #region Eigenschaften
        private OpenWeatherMapResponseParser parser;
        private string weatherApiKey;
        string responseFromServer = "";
        #endregion

        public OpenWeatherMapClient(string appid, OpenWeatherMapResponseParser parser)
        {
            this.weatherApiKey = appid;
            this.parser = parser;
        }

        public WetterBeschreibung GetWetterResponse(string stadt)
        {
            string openweatherURL = "http://api.openweathermap.org/data/2.5/weather?q=" + stadt + "&appid=" + weatherApiKey;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(openweatherURL);

            //try für fehler abfangen
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
            }
            WetterBeschreibung beschreibung = new WetterBeschreibung();
            beschreibung.setBeschreibung(parser.ParseBeschreibung(responseFromServer));
            beschreibung.setTemperatur(parser.ParseTemperatur(responseFromServer));
            return beschreibung;
        }
    }
}
