using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemInheritance
{
    class MedStaff
    {
        private int employee_id;
        private string fname;
        private string lname;
        private string dateOfBirth;
        private string NI_number;
        private double salary;

        public MedStaff()
        {
            employee_id = 0;
            fname = "";
            lname = "";
            dateOfBirth = "";
            NI_number = "";
            salary = 0.0;
        }


        public void set_med_details()
        {
            Console.Write("Enter employee id: ");
            this.employee_id = int.Parse(Console.ReadLine());

            Console.Write("Enter first name: ");
            this.fname = Console.ReadLine();

            Console.Write("Enter last name: ");
            this.lname = Console.ReadLine();

            Console.Write("Enter Date of Birth (DOB): ");
            this.dateOfBirth = Console.ReadLine();

            Console.Write("Enter NI Number: ");
            this.NI_number = Console.ReadLine();

            Console.Write("Enter Salary: ");
            this.salary = double.Parse(Console.ReadLine());

        }

        public void print_med_details()
        {
            Console.WriteLine($"Employee id is {get_empid()}");
            Console.WriteLine($"First name is {get_fname()}");
            Console.WriteLine($"Last name is {get_lname()}");
            Console.WriteLine($"Date of Birth (DOB)is {get_dob()}");
            Console.WriteLine($"NI Number is {get_NInum()}");
            Console.WriteLine($"Salary is {get_salary()}");

        }

        public int get_empid()
        {
            return employee_id;
        }

        public string get_fname()
        {
            return fname;
        }
        public string get_lname()
        {
            return lname;
        }
        public string get_dob()
        {
            return dateOfBirth;
        }
        public string get_NInum()
        {
            return NI_number;
        }
        public double get_salary()
        {
            return salary;
        }
    }
}
