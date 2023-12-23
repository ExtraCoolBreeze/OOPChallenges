using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
namespace RouletteProgram
{
    class Program
    {
        public static int chipsTotal = 200;
        public static Boolean tryAgain = true;


        public static void Main()
        {
            Console.WriteLine("Welcome to the casino games program");

            do
            {
                Menu();
                Console.WriteLine("Would you like to close the game?");
                Console.WriteLine("Press y to close or n to continue");
                string exit = Console.ReadLine();
                if (exit == "y")
                {
                    break;
                }
            }
            while (tryAgain == true);
        }

        // Displaying menu
        static void Menu()
        {
            Console.WriteLine("Please choose a game");
            Console.WriteLine("1. Roulette");
            Console.WriteLine("2. BlackJack");
            Console.WriteLine("3. Slots");
            Console.WriteLine("4. High/Low");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter a number between 1 and 5");
            //get user input for game choice
            int selectedNumber = getChoice();
            //check user choice in switch statement 
            userChoice(selectedNumber, ref tryAgain);
        }

        //getting user input
        public static int getChoice()
        {
            int userNumber;
            userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        // Selecting game choice along with calling appropriate game functions
        public static void userChoice(int selectedNumber, ref Boolean tryAgain)
        {
            switch (selectedNumber)
            {
                case 1:
                    Console.WriteLine("You have chosen Roulette");
                    Console.WriteLine("Press y to continue or n to back out");
                    string back = Console.ReadLine();
                    if (back == "y")
                    {
                        // Currently haven't fully been able to resolve chips issue
                        // 
                        while (tryAgain == true)
                        {
                            int chipsTemp = chipsCounter();
                            if (chipsTemp == 0)
                                {
                                    break;
                                }
                            int potentialWinner = rouletteChoice();
                            int winningNumber = get_random_number();
                            winCheck(potentialWinner, winningNumber);
                            tryAgain = againCheck();
                        } 
                    }
                    Console.WriteLine("You have selected back out or have no chips to continue");                      
                    break;
                case 2:
                    Console.WriteLine("You have chosen BlackJack");
                    // code block
                    break;
                case 3:
                    Console.WriteLine("You have chosen Slots");
                    // code block
                    break;
                case 4:
                    Console.WriteLine("You have chosen High/Low");
                    // code block
                    break;
                case 5:
                    Console.WriteLine("You have chosen Exit");
                    // code block
                    break;
                default:
                    Console.WriteLine("Please select a number between 1 and 5");
                    // code block
                    break;
            }
        }

        // Generating random number within a defined range
        static int get_random_number()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            // The + 1 can be useful if the start is from 0, i.e. 0 to 10.
            // Because this will give 1 to 10 
            return random.Next(0, 36);
        }

        //getting user choice for random number
        public static int rouletteChoice()
        {
            int rouletteNumber;
            Console.WriteLine("Please choose a number between 0 and 36");
            rouletteNumber =  Convert.ToInt32(Console.ReadLine());
            return rouletteNumber;
        }

        //Account chip check
        public static int chipsCounter()
        {
            Console.WriteLine("You have " + chipsTotal + " total chips");
            Console.WriteLine("Its 50 chips to play");
            addChips();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            if (chipsTotal <= 0)
            {
                Console.WriteLine("You have no chips. You cannot play");
                return 0;
            }
            return chipsTotal;
        }

        // Checking if user won roulette
        static void winCheck(int potentialWinner, int winningNumber)
        {
            if (potentialWinner == winningNumber)
            {
                Console.WriteLine("Player Wins!");
                int tempTotal = 50 * 36;
                chipsTotal += tempTotal;
            }
            else 
            { 
                Console.WriteLine("Player Loses!");
                chipsTotal = chipsTotal - 50;
                Console.WriteLine("You have " + chipsTotal + " total chips remaining");
                Console.WriteLine("Would you like to try again?");
            }
        }

        //Checking if user wants to continue playing
        static bool againCheck()
        {
            Console.WriteLine("Press y to continue or n to back out");
           string againTemp = Console.ReadLine();
            if (againTemp == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        //Function to add chips to account
        static void addChips()
        {
            Console.WriteLine("Would you like to add more chips to your account?");
            Console.WriteLine("Type y for yes and n for no");
            string moreChips = Console.ReadLine();
            if (moreChips == "y")
            {
                Console.WriteLine("How many chips would you like to add? Examples: 100, 500, 1000");
                int totalTemp = Convert.ToInt32(Console.ReadLine());
                chipsTotal = chipsTotal + totalTemp;
                Console.WriteLine("You now have " + chipsTotal + " total chips");
            }
        }
    }
}