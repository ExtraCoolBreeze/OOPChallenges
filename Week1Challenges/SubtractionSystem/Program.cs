namespace SubtractionSystem
{

    class Program { 
    
        public static void Main(string[] args)
        {
            string subtractApp = "Subtraction System";
            Console.WriteLine(subtractApp);
            Console.WriteLine("Please two 2 numbers in the order that you'd like to subtract");

            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first number is:" + inputOne);
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is:" + inputTwo);

            Console.WriteLine(" "+ inputOne + " take away " + inputTwo + " = " + Calculate(inputOne, inputTwo));
        }

        public static double Calculate(int numbOne, int numbTwo) {

            return numbOne - numbTwo;
        
        }

    }

}