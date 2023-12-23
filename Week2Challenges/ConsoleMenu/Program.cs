using Microsoft.VisualBasic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleMenu
{
    using System;

    class Program
    {
        //Here I am declaring result as a class level variable so it can be used outside of main
        static string result;
        static void Main()
        {

            //Here I am declaring local variables in main
            int choice;
            int total = 0;
            double average = 0;
            int examMark1 = 0;
            int examMark2 = 0;
            

            //This is shows the menu on a loop, calls functions and quits when 5 is selected
            do
            {
                // Display the menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Get Exam Marks");
                Console.WriteLine("2. Calculate Total");
                Console.WriteLine("3. Calculate Average");
                Console.WriteLine("4. Display Result");
                Console.WriteLine("5. Exit");

                // Get user input
                Console.Write("Enter your choice (1-5): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    // Process user choice
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You selected Option 1 - Get Exam Marks ");
                            Console.WriteLine("Get Exam Marks");
                            Console.WriteLine("Please enter the first mark");
                            examMark1 = getMarks();
                            Console.WriteLine("Exam mark 1 = " + examMark1);
                            Console.WriteLine("Please enter the second mark");
                            examMark2 = getMarks();
                            Console.WriteLine("Exam mark 2 = " + examMark2);
                            break;
                        case 2:
                            Console.WriteLine("You selected Option 2 - Calculate Total ");
                            total = totalOverall(examMark1, examMark2);
                            Console.WriteLine("The total is = " + total);
                            break;
                        case 3:
                            Console.WriteLine("You selected Option 3 - Calculate Average");
                            average = averageMarks(total);
                            Console.WriteLine("The average is = " + average);
                            break;
                        case 4:
                            Console.WriteLine("You selected Option 4 - Display Result ");
                            Console.WriteLine(displayResult(total));
                            break;
                        case 5:
                            Console.WriteLine("You selected Option 5 - Exit ");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
            while (choice != 5);

        }
        //This function gets marks as user input
        public static int getMarks()
        {

            return Convert.ToInt32(Console.ReadLine());
        }

        //this function totals the marks
        public static int totalOverall(int examMark1, int examMark2)
        {
            return examMark1 + examMark2;
        }

        //This function calculates the average
        public static double averageMarks(int total)
        {
            if (total == 0)
            {
                Console.WriteLine("Cannot calculate the average. The total is 0");
            }

            double averageDouble = total / 2;

            return averageDouble;
        }

        //This function checks if the results are a pass
        public static string displayResult(int total) 
        {
            if (total >= 50)
            {
                result = "You have passed the course";
            }
            else if (total == 0 || total < 50)
            {
                result = "You have not scored enough overall to pass the course";
            }
            else
            {
                result = "error - exam total number is null or out of range";
            }
            return result;
        }
    }
}