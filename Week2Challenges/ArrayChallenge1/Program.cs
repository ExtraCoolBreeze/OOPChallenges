using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
namespace ArrayChallenge1
{
    class Program
    {
        static int arrayTotal;
        public static void GetNumbers(int[] number_array)
        {
            // fill the array
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number for array location {0}: ", i);
                number_array[i] = int.Parse(Console.ReadLine()); // fill array
            }
        }
        public static void DisplayArray(int userChoice, int[] number_array)
        {
            if (userChoice != 9)
            {
                Console.WriteLine();
                Console.WriteLine("Position ID");
                Console.WriteLine();
                Console.WriteLine("0  1  2  3  4");
                Console.WriteLine("-------------");
                Console.WriteLine();

                // display the array
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(number_array[j]);
                    Console.Write("  ");
                    calTotal(number_array[j]);
                }
                Console.WriteLine();
                Console.WriteLine();
                displayTotal();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Position ID");
                Console.WriteLine();
                Console.WriteLine("4  3  2  1  0");
                Console.WriteLine("-------------");
                Console.WriteLine();

                // display the array
                for (int j = 4; j >= 0; j--)
                {
                    Console.Write(number_array[j]);
                    Console.Write("  ");
                    calTotal(number_array[j]);
                }
                Console.WriteLine();
                Console.WriteLine();
                displayTotal();
            }
            

        }

        public static void PressAnyKey()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] number_array = new int[5]; // set up array
            GetNumbers(number_array);
            int userChoice = Choice();
            DisplayArray(userChoice, number_array);
            PressAnyKey();
            int target = targetInput();
            int resultPosition = Search(number_array, target);
            Result(resultPosition);
            Console.WriteLine("The average of the numbers in the array is " + averageCalc());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }

        public static void calTotal(int arrayTemp)
        {
            arrayTotal = arrayTotal + arrayTemp;
        }

        public static void displayTotal()
        {
            Console.WriteLine("The total of all the elements in the array is: " + arrayTotal);
        }

        public static int targetInput()
        {
            Console.WriteLine("Please enter a value you'd like to search for");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Search(int[] number_array, int target)
        {
            for (int j = 0; j < number_array.Length; j++)
            {
                if (number_array[j] == target)
                {
                    return j; // Return the index where the target is found
                }
            }
            return -1; // Return -1 if the target is not found in the array
        }

        public static void Result(int resultPosition)
        {
            if (resultPosition != -1)
            {
                Console.WriteLine("The target number was found at index: " + resultPosition);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The target number was not found in the array");
                Console.WriteLine();
            }
        }

        public static double averageCalc()
        {
            Console.WriteLine("Finding the average of entered array numbers");
            Console.WriteLine();
            double averageResult = arrayTotal / 5;
            return averageResult;
        }

        public static int Choice()
        {
            Console.WriteLine("If you would you like to view the array from 5 to 1, press 9 ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
    }
}