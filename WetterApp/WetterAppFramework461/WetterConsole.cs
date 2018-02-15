using System;
using System.Collections.Generic;
using System.Text;

namespace WetterAppFramework461
{
    class WetterConsole
    {
        private OpenWeatherMapClient client;

        public WetterConsole(OpenWeatherMapClient client)
        {
            this.client = client;
        }

        internal void start()
        {
            string stadt = "";
            while(!stadt.Equals("exit") || !stadt.Equals("e") || !stadt.Equals("quit") || !stadt.Equals("q"))
            {
                Console.WriteLine("Von welcher Stadt soll das Wetter angezeigt werden?");
                stadt = Console.ReadLine();
                zeigWetter(stadt);
            }
        }

        private void zeigWetter(string stadt)
        {
            WetterBeschreibung beschreibung = client.getWetterResponse(stadt);
        }
    }
}
