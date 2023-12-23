using System;

namespace ShapesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            Console.WriteLine("Printing Shapes");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine("A Factory");
            Console.WriteLine("---------");
            Console.WriteLine("");
            Tube();
            largeRectangle();
            Enter();
            Clear();
            Console.WriteLine("");
            Console.WriteLine("A House");
            Console.WriteLine("-------");
            Console.WriteLine("");
            Triangle();
            Square();
            Enter();
            Clear();
            Console.WriteLine("");
            Console.WriteLine("A Block of Flats");
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Square();
            Square();
            Square();
            Enter();
            Clear();
            Console.WriteLine("");
            Console.WriteLine("A Tree");
            Console.WriteLine("-------");
            Console.WriteLine("");
            Triangle();
            Tube();
            Enter();
        }

        public static void Tube()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("    | |    ");
            }
        }

        public static void Clear()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("");
            }
        }
        public static void largeRectangle()
        {
            Console.WriteLine("---------------------- ");
            Console.WriteLine("|                    | ");
            Console.WriteLine("|                    | ");
            Console.WriteLine("|                    | ");
            Console.WriteLine("|                    | ");
            Console.WriteLine("---------------------- ");
        }

        public static void Triangle()
        {
            Console.WriteLine("     ^       ");
            Console.WriteLine("   /   \\    ");
            Console.WriteLine("  /     \\   ");
            Console.WriteLine(" /       \\  ");
            Console.WriteLine("/         \\ ");
            Console.WriteLine("-----------  ");
        }

        public static void Enter()
        {
            Console.WriteLine("");
            Console.Write("Press the [Enter] key");
            Console.ReadLine();
        }
        public static void Square()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("-----------");
        }
    }
}