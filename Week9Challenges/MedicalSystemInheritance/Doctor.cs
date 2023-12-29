using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemInheritance
{
    class Doctor : MedStaff
    {
        string doc_rank;
        string speciality;

        public Doctor()
        {
            doc_rank = "";
            speciality = "";
        }
        public void set_doc_details()
        {
            // Call set_med_details to print from the base class
            set_med_details();
            Console.Write("Enter rank: ");
            this.doc_rank = Console.ReadLine();

            Console.Write("Enter speciality: ");
            this.speciality = Console.ReadLine();
        }

        public string get_doc_rank()
        {
            return doc_rank;
        }
        public string get_speciality()
        {
            return speciality;
        }

        public void print_doc_details()
        {
            // Call print_med_details to print from the base class
            print_med_details();

            Console.WriteLine($"Doctor rank is: {get_doc_rank()}");

            Console.WriteLine($"Speciality is:  {get_speciality()}");
        }


    }
}
