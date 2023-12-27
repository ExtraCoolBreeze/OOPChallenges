namespace MultipleClasses;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square();
        Cube cu1 = new Cube();
        Console.WriteLine("Square of numbers from 1 to 10");
        sq1.calc_square();
        Console.WriteLine("Cube of numbers from 1 to 10");
        cu1.calc_cube();
        Console.ReadLine();
    }
}