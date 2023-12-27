using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    public class Square
    {
        // Variables
        private int num_square;
        private int i;

        // Constructor
        public Square()
        {
            num_square = 0;
        }

        // Methods
        public void calc_square()
        {
            for (i = 1; i <= 10; i++)
            {
                num_square = i * i;
                print_results();
            }
        }

        public void print_results()
        {
            Console.WriteLine(i + "\t" + num_square + "\n");
        }
    }
}
