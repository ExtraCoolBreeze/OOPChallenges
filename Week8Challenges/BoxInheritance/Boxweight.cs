using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxInheritance
{
    // Inheriting from box class
    class Boxweight : Box
    {
        //setting private variable
        private double weight;

        // Creating Constructor
        public Boxweight()
        {
            weight = 0.0;
        }

        //Creating method to get user input for weight of box
        //Calling set_vals function from base class
        public void set_weight(double weight)
        {
            set_vals(); // Call method from base class

            Console.Write("Enter a weight for the box: ");
            weight = int.Parse(Console.ReadLine());
        }

        //returning weight variable
        public double get_weight(double weight)
        {
            return weight;
        }

        //Creating a method that calls Sub and base class method and function
        public void print_results(double weight)
        {
            Console.WriteLine();
            Console.Write("The volume is " + calculate_volume() + " ");
            Console.WriteLine();
            Console.WriteLine("The weight is " + get_weight(weight));
        }

    }

}
