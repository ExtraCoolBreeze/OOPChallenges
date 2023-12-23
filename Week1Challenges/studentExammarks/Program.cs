using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace studentExammarks
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Calculate exam marks program");
            Console.WriteLine("Please enter the students marks over 3 exams");
            int studentMarks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student exam mark 1 = " + studentMarks1);
            int studentMarks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student exam mark 2 = " + studentMarks2);
            int studentMarks3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student exam mark 3 = "  + studentMarks3);

            int total = totalOverall(studentMarks1, studentMarks2, studentMarks3);
            Console.WriteLine("The total student mark is: " + total);
            double studentAverage = averageMarks(total);
            Console.WriteLine("The average student mark is: " + studentAverage);
        }

        public static int totalOverall(int studentMarks1, int studentMarks2, int studentMarks3)
        {
            return studentMarks1 + studentMarks2 + studentMarks3;
        }

        public static double averageMarks(int total)
        {
            return total / 3;
        }

        public static void taxCheck(int total)
        {

            if (total >= 150)
            {
                Console.WriteLine("You have passed the course");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have not scored enough overall to pass the course");
                Console.ReadLine();
            }
        }
    }
}