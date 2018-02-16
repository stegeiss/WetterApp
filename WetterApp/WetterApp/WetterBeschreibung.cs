using System;
using System.Collections.Generic;
using System.Text;

namespace WetterApp
{
    class WetterBeschreibung
    {
        private const double Kelvin = 273.15;
        private string beschreibung;
        private string temperatur;
        private string fehlerBeschreibung;
        internal void SetBeschreibung(string beschreibung)
        {
            this.beschreibung = beschreibung; ;
        }
        internal void SetTemperatur(string temperatur)
        {
            this.temperatur = temperatur;
        }
        internal void SetFehler(string message)
        {
            fehlerBeschreibung = message;
        }

        private double TemperaturVonKelvinAufGrad()
        {
            double temp = double.Parse(temperatur);
            return temp-Kelvin;
        }

        public override string ToString()
        {
            string returnText;
            if (fehlerBeschreibung != null)
            {
                returnText = fehlerBeschreibung;
            }
            else
                returnText = "Das Wetter ist: " + beschreibung + " und die Temperatur beträgt: " + TemperaturVonKelvinAufGrad().ToString("0.##") + "°C Grad.";
            return returnText;
        }

    }
}
