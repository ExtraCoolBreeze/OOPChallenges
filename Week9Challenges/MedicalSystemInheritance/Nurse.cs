using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemInheritance
{
    class Nurse : MedStaff
    {
        string nurse_rank;
        int ward_num;

        public Nurse()
        {
            nurse_rank = "";
            ward_num = 0;
        }
        public void set_nurse_details()
        {
            set_med_details();
            Console.Write("Enter rank: ");
            this.nurse_rank = Console.ReadLine();

            Console.Write("Enter ward number: ");
            this.ward_num = int.Parse(Console.ReadLine());
        }
        public string get_nurse_rank()
        {
            return nurse_rank;
        }
        public int get_ward_num()
        {
            return ward_num;
        }

        public void print_nurse_details()
        {
            print_med_details();

            Console.WriteLine($"Doctor rank is: {get_nurse_rank()}");

            Console.WriteLine($"Speciality is:  {get_ward_num()}");

        }
    }
}
