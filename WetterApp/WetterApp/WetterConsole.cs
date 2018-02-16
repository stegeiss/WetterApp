using System;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
{
    class WetterConsole
    {
        private bool BenutzerWillBeenden = false;
        private OpenWeatherMapClient client;

        public WetterConsole(OpenWeatherMapClient client)
        {
            this.client = client;
        }

        internal void start()
        {
            string stadt = "";
            while (!BenutzerWillBeenden)
            {
                //expextion

                Console.WriteLine("Von welcher Stadt soll das Wetter angezeigt werden?");
                stadt = Console.ReadLine();
                if (stadt.Equals("exit") || stadt.Equals("e") || stadt.Equals("quit") || stadt.Equals("q"))
                {
                    BenutzerWillBeenden = true;
                }
                else
                {
                    zeigWetter(stadt);
                }
            }
        }


        private void zeigWetter(string stadt)
        {
            WetterBeschreibung beschreibung = client.GetWetterResponse(stadt);
            Console.WriteLine(beschreibung);
        }
    }
}
