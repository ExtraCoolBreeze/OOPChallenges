namespace ConversionAndTemperature
{
    class Program
    {
        public static void Main()
        { 
            Convert c = new Convert();

            c.SetInches();
            Console.WriteLine( " Your number in CM is: " + c.GetCM());
        }
    }
}