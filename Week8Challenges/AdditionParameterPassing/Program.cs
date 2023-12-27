namespace AdditionalParameterPassing;

class Program
{
    public static void Main(string[] args)
    {
        Addition add = new Addition();

        add.get_Nums();
        add.set_Total();
        add.print_Total();
    }

    class Addition()
    {
        private int num1 = 0;
        private int num2 = 0;
        private int total = 0;

        public void get_Nums()
        {
            Console.Write("Enter first number: ");
            this.num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            this.num2 = int.Parse(Console.ReadLine());
        }

        public int set_Total()
        {
            return this.total = num1 + num2;
        }

        public void print_Total()
        {
            Console.WriteLine("");
            Console.WriteLine("Total = " + set_Total());
            Console.WriteLine("");
            Console.WriteLine("\nThanks for using the program");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}