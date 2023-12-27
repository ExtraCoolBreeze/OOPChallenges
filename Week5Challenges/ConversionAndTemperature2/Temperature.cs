using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAndTemperature2
{
    internal class Temperature
    {
        private int Fahr;

        public void SetF()
        {
            Console.WriteLine("Please enter a number in Fahrenheit");
            Fahr = int.Parse(Console.ReadLine());
        }

        public double GetC()
        { 
            double centi = (Fahr - 32) * 5 / 9;
            return centi;
        }
    }
}
