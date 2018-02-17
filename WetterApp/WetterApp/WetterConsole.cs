using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WetterApp
{
    class WetterConsole
    {
        public bool BenutzerWillBeenden { get; private set; }
        private OpenWeatherMapClient client;
        private List<StadtListe> stadteListe = new List<StadtListe>();

        public WetterConsole(OpenWeatherMapClient client)
        {
            this.client = client;
            BenutzerWillBeenden = false;
            //StadteListeEinlesen(); Wird noch bearbeitet: eventuell für Fehl eingabe überprüfen
        }

        internal void Start()
        {
            string stadt = "";
            while (!BenutzerWillBeenden)
            {
                Console.WriteLine("Von welcher Stadt soll das Wetter angezeigt werden?");
                stadt = Console.ReadLine();
                if (stadt.Equals("exit") || stadt.Equals("e") || stadt.Equals("quit") || stadt.Equals("q"))
                {
                    BenutzerWillBeenden = true;
                }
                else
                {
                    ZeigWetter(stadt);
                }
            }
        }

        private void ZeigWetter(string stadt)
        {
            WetterBeschreibung beschreibung = client.GetWetterResponse(stadt);
            Console.WriteLine(beschreibung);
        }

        private void StadteListeEinlesen()
        {
            JArray json;
            using (StreamReader file = File.OpenText(@"city.list"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                json = (JArray)JToken.ReadFrom(reader);
            }
            for (int i = 0; i < json.Count; i++)
            {
                int id = int.Parse(json[i]["id"].ToString());
                stadteListe.Add(new StadtListe(id,
                                                json[i]["name"].ToString(),
                                                json[i]["country"].ToString(),
                                                json[i]["coord"]["lon"].ToString(),
                                                json[i]["coord"]["lat"].ToString()));
            }
        }
    }
}
