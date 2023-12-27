using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAndTemperature
{
    internal class Convert
    {
        private int inches;

        public Convert()
        {
            inches = 0;
        }

        public void SetInches()
        {
            Console.WriteLine("Please input the number of inches");
            inches = int.Parse(Console.ReadLine());
        }

        public double GetCM()
        {
            return inches * 2.54;
        }
    }
}