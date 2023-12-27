using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialConversion
{
    internal class ConvertPintsToLitres
    {
        private int pint;
        public ConvertPintsToLitres()
        { 
            this.pint = 0;
        }

        public void set_pint()
        {
            Console.WriteLine("Please could enter the number in pints");
            this.pint = (int.Parse(Console.ReadLine()));
        }

        public double calc_litres()
        {
            return this.pint * 0.57;
        
        }

        public void print_litres()
        {
            Console.WriteLine("The number in litres is " + calc_litres().ToString("F2") + "L" );
        }
    }
}
