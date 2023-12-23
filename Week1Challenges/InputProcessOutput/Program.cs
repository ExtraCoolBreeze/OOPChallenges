using System.Numerics;

namespace InputProcessOutput
{
    class Program
    {
        // Addition system - Challenge 1

        public static void Main()
        {
            string AdText = "Addition System";
            Console.WriteLine(AdText);
            Console.WriteLine("Please input 2 numbers");


            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your first number is: " + firstNumb);
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your second number is: "+ secondNumb);

            Console.WriteLine("The total is: " + Calculate(firstNumb, secondNumb));
            Console.ReadLine();

        }

        public static int Calculate(int firstNumb, int secondNumb)
        {
            return firstNumb + secondNumb;
        }
    }
}