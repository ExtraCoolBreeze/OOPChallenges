using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace HoursWorkedChallenge2
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Calculate total pay program");
            Console.WriteLine("Hourly living wage is £ 11.44");
            Console.WriteLine("Please enter your hours");
            double hours = Convert.ToDouble(Console.ReadLine());
            double totalPay = hourlyCalc(hours);
            Console.WriteLine("Your total pay before tax is: £" + totalPay);
            taxCheck(totalPay);
        }

        public static double hourlyCalc(double hours)
        {
            return hours * 11.44;
        }

        public static void taxCheck(double totalPay)
        {

            if (totalPay >= 500)
            {
               Console.WriteLine("After checking tax calculations, you have to pay tax");
                Console.WriteLine("Your pay after tax is: £" + taxCalc(totalPay));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("After checking tax calculations, you do not have to pay tax");
                
            }
        }
        public static double taxCalc(double totalPay)
        {
           return totalPay - 30;
        }
    }
}