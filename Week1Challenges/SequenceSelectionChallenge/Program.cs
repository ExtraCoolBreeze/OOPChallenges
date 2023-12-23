using Microsoft.VisualBasic;

namespace SequenceSelectionChallenge
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Inch to Centimeter Conversion Program");
            Console.WriteLine("1 inch = 2.54 centimetres");
            Console.WriteLine("Please enter a number in inches to convert");
            double inches = Convert.ToDouble(Console.ReadLine());

            double CentValidate = CentConv(inches);
            Console.WriteLine( " " + CentValidate + "cm" + " = " + inches + "in" + " in inches");

            if (CentValidate >= 30)
            {
                Console.WriteLine("Acceptable length for shelf");

            }
            else { 
                Console.WriteLine("NOT acceptable length for shelf.");
            
            }
            Console.ReadLine();
        }

        public static double CentConv(double inches)
        {
            return inches * 2.54;
        }
    }
}
