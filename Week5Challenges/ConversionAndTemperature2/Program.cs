namespace ConversionAndTemperature2
{
    class Program
    {
        static void Main()
        { 
            Temperature t = new Temperature();

            t.SetF();
            Console.WriteLine("Your number in centigrade is: " + t.GetC());
        }
    }
}