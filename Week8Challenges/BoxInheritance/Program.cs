using System.Runtime.InteropServices;

namespace BoxInheritance;
class Program
{
    static void Main(string[] args)
    {
        //hard coding user input
        double w = 10.0;

        //instantiating boxweight
        Boxweight box1 = new Boxweight();

        //Calling Boxweight functions
        box1.set_weight(w);
        box1.print_results(w);

        Console.ReadLine();

    }
}
