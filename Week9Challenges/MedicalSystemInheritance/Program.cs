namespace MedicalSystemInheritance;

class Program
{
    
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor();
            Nurse nurse1 = new Nurse();

            int choice = 0;

            do
            {
                Console.Clear();
                display_menu();
                get_choice(ref choice);
                act_on_choice(choice, ref doctor1, ref nurse1);
            }
            while (choice != 3);

            Console.WriteLine("");
            Console.Write("Thanks for using the program.");
            Console.WriteLine("");
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }


        static void display_menu()
        {
            Console.WriteLine("Medical staff");
            Console.WriteLine("1. Doctor details");
            Console.WriteLine("2. Nurse details");
            Console.WriteLine("3. Exit\n");
            Console.WriteLine("Enter choice 1-3");
        }

        static void get_choice(ref int choice)
        {
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
        }


        static void act_on_choice(int choice, ref Doctor doctor1, ref Nurse nurse1)
        {
            switch (choice)
            {
                case 1:
                    {
                        doctor1.set_doc_details();

                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        doctor1.print_doc_details();
                    }
                    break;

                case 2:
                    {
                        nurse1.set_nurse_details();

                        Console.Write("Press any key to continue...");
                        Console.ReadLine();

                        nurse1.print_nurse_details();
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Closing the program...");
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            } //end switch
        }

    
}