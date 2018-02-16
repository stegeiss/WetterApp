using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
{
    internal class StadtListe
    {
        internal class Koordinaten
        {
            public Koordinaten(string lon, string lat)
            {
                Lon = lon;
                Lat = lat;
            }

            public string Lon { get; set; }
            public string Lat { get; set; }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Koordinaten Coord { get; set; }

        public StadtListe(int id, string name, string country, string lon, string lat)
        {
            Id = id;
            Name = name;
            Country = country;
            Coord = new Koordinaten(lon, lat);
        }
    }
}
