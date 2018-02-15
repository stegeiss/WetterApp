using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace WetterApp
{
    class WetterApp
    {
        private static string openWeatherMapKey = "0c5f1d25e6b2bc4b09d7077b4a85fb47";

        static void Main(string[] args)
        {
            OpenWeatherMapResponseParser parser = new OpenWeatherMapResponseParser();
            OpenWeatherMapClient client = new OpenWeatherMapClient(openWeatherMapKey, parser);
            WetterConsole console = new WetterConsole(client);
            console.start();
        }
    }
}
