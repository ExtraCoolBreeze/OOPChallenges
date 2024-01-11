using System.Numerics;

namespace School_InventorySystem
{ 

    class Program
    {
        static void Main()
        {
            Computer computer1 = new Computer(); 
            cadcomputer cadcomputer1 = new cadcomputer();
            Apple apple1 = new Apple();

            int choice = 0;

            do
            {
                Console.Clear();
                display_menu();
                get_choice(ref choice);
                act_on_choice(choice, ref computer1, ref cadcomputer1, ref apple1);
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
            Console.WriteLine("Types of Computer");
            Console.WriteLine("1. General Computer");
            Console.WriteLine("2. CAD Computer");
            Console.WriteLine("3. Apple Computer");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice 1-4");
        }

        static void get_choice(ref int choice)
        {
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
        }

        static void act_on_choice(int choice, ref Computer computer1, ref cadcomputer cadcomputer1, ref Apple apple1)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("You have selected General Computer");
                        computer1.set_comp_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        computer1.print_computer_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("You have selected CAD Computer");
                        cadcomputer1.Set_CAD_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        cadcomputer1.Print_CAD_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();                        
                   }
                    break;

                case 3:
                    {
                        Console.WriteLine("You have selected Apple Computer");
                        apple1.Add_mac_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        apple1.Print_mac_details();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();                       
                    }
                    break;
                case 4:
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