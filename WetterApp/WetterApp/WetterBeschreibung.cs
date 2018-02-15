using System;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
{
    class WetterBeschreibung
    {
        private string beschreibung;
        private string temperatur;
        public void setBeschreibung(string beschreibung)
        {
            this.beschreibung = beschreibung; ;
        }

        internal void setTemperatur(string temperatur)
        {
            this.temperatur = temperatur;
        }

        public override string ToString()
        {
            return "Das Wetter ist: " + beschreibung + " und die Temperatur beträgt: " + temperatur + " Kelvin.";
        }
    }
}
