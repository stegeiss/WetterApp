using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace WetterApp
{
    class WetterApp
    {
        private static string openWeatherMapKey = "";

        static void Main(string[] args)
        {
            OpenWeatherMapResponseParser parser = new OpenWeatherMapResponseParser();
            OpenWeatherMapClient client = new OpenWeatherMapClient(openWeatherMapKey, parser);
            WetterConsole console = new WetterConsole(client);
            console.start();
        }
    }
}
