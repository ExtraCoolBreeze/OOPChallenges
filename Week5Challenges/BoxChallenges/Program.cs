using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace BoxChallenges
{
    // Program incomplete, still to come to an adequate solution
    class Validation
    { 
        public void inputValidation(double height, double width, double depth)
        {
            //Need to validate inputs before calling b.set_details();
        }
    }

    class Box
    {
        // member variables
        private double height;
        private double width;
        private double depth;

        // constructor
        public Box()
        {
            height = 0;
            width = 0;
            depth = 0;
        }

        public void set_details()
        // input details from the user
        {
            Console.WriteLine("Enter height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter depth: ");
            depth = double.Parse(Console.ReadLine());

        }


        public double get_volume()
        // calculate the volume
        {
            return height * width * depth;
        }

        public void display_volume()
        // call the calculate function and display the result
        {
            Console.Write("The volume is: " + get_volume());
        }

        static void Main(string[] args)
        // main program
        {
            Box b = new Box();  // instantiate object
            Validation uVal = new Validation();

            uVal.inputValidation(b.set_details(height, width, depth));

            ////////////////////////////////////////////
            //b.set_details();
            b.display_volume();
            Console.ReadLine();

        } // end of main program
    } // end of Box class
}