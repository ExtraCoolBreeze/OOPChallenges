using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_InventorySystem
{
    class cadcomputer : Computer
    {
       private string software;
       private string tablet_type;

        public cadcomputer()
        {
            software = "";
            tablet_type = "";
        }

        public void Set_CAD_details()
        {
            set_comp_details();

            Console.Write("Enter software: ");
            this.software = Console.ReadLine();

            Console.Write("Enter make: ");
            this.tablet_type = Console.ReadLine();
        }

        public string Getsoftware()
        { 
            return software;
        }

        public string GetTabletType()
        {
            return tablet_type;
        }

        public void Print_CAD_details()
        {
            print_computer_details();
            Console.WriteLine($"The software is {Getsoftware()}");
            Console.WriteLine($"Make is {GetTabletType()}");
        }
    }
}
