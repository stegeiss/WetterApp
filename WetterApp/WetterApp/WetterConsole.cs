using System;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
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
            //expextion
            string stadt = "";
            while(!stadt.Equals("exit") || !stadt.Equals("e") || !stadt.Equals("quit") || !stadt.Equals("q"))
            {
                Console.WriteLine("Von welcher Stadt soll das Wetter angezeigt werden?");
                stadt = Console.ReadLine();
                zeigWetter(stadt);
            }
            Console.WriteLine("huhu");
        }

        private void zeigWetter(string stadt)
        {
            WetterBeschreibung beschreibung = client.GetWetterResponse(stadt);
            Console.WriteLine(beschreibung);
        }
    }
}
