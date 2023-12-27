using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClasses
{
    public class Cube
    {
        // Variables
        private int num_cube;
        private int i;


        // Constructor
        public Cube()
        {
            num_cube = 0;
        }

        // Methods
        public void calc_cube()
        {
            for (i = 1; i <= 10; i++)
            {
                num_cube = i * i * i;
                print_results();
            }
        }

        public void print_results()
        {
            Console.WriteLine(i + "\t" + num_cube + "\n");
        }
    } 
}
