using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxInheritance
{
    //Creating abstract class as a base class
    abstract class Box
    {
        // creating read only variables
        protected int height;
        protected int width;
        protected int depth;

        // Creating Constructor
        
        public Box()
        {
            width = 0;
            height = 0;
            depth = 0;
        }

        //Creating method to get user input
        public void set_vals()
        {
            Console.Write("Enter width of box: ");
            width = int.Parse(Console.ReadLine());

            Console.Write("Enter height of box: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("Enter depth of box: ");
            depth = int.Parse(Console.ReadLine());
        }

        // Function to calculate volume of a cube
        public int calculate_volume()
        {
            return width * height * depth;
        }
    }

}
