using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterAppFramework461
{
    class Program
    {
        static void Main(string[] args)
        {

            OpenWeatherMapResponseParser parser = new OpenWeatherMapResponseParser();
            OpenWeatherMapClient client = new OpenWeatherMapClient(parser);
            WetterConsole console = new WetterConsole(client);
            console.start();
            //Console.WriteLine("Hello World!");
        }
    }
}
