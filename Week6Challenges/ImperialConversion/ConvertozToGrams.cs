using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialConversion
{
    internal class ConvertozToGrams
    {
        private int oz;

        public ConvertozToGrams()
        { 
            this.oz = 0;
        }

        public void set_oz()
        {
            Console.WriteLine("Please enter a number in ounces");
            this.oz = int.Parse(Console.ReadLine());
        }

        public double calc_grams()
        {
            return this.oz * 28.35;
        }

        public void print_grams()
        {
            Console.WriteLine("The number in grams is: " + calc_grams().ToString("F2") + "g");
        }
    }
}
