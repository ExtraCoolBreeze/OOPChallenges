using System;

namespace VehicleSystem
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle1 = new Vehicle();
            Van van1 = new Van();
            Car Car1 = new Car();

            int choice = 0;

            do
            {
                Console.Clear();
                display_menu();
                get_choice(ref choice);
                act_on_choice(choice, ref vehicle1, ref van1, ref Car1);
            }
            while (choice != 4);

            Console.WriteLine("");
            Console.WriteLine("Thanks for using the program.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void display_menu()
        {
            Console.WriteLine("Vehicle details menu");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Display Car");
            Console.WriteLine("3. Add Van");
            Console.WriteLine("4. Display Van");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter choice 1-5");
        }

        static void get_choice(ref int choice)
        {
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
        }

        static void act_on_choice(int choice, ref Vehicle vehicle1, ref Van van1, ref Car Car1)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("You have selected 1. Add Car");
                        Car1.Setnum_of_seats();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("You have selected 2. Display Car");
                        Car1.Print_num_of_seats();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("You have selected 3. Add Van");
                        van1.Setloading_space();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("You have selected 4. Display Van");
                        van1.Print_loading_space();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    break;

                case 5:
                    { 
                    
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            } //end switch
        }
    }
}