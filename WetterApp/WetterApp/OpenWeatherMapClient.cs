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
            WetterBeschreibung beschreibung = new WetterBeschreibung();

            try
            {
                WebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                beschreibung.SetBeschreibung(parser.ParseBeschreibung(responseFromServer));
                beschreibung.SetTemperatur(parser.ParseTemperatur(responseFromServer));
            }
            catch (Exception e)
            {
                beschreibung.SetFehler(e.Message);
            }
            return beschreibung;
        }
    }
}
