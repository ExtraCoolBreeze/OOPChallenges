using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_InventorySystem
{
    class Apple : Computer
    {
        private string OP_system;

        public Apple()
        {
            OP_system = "";
        }

        public void Add_mac_details()
        {
            set_comp_details();

            Console.Write("Enter Operating system: ");
            this.OP_system = Console.ReadLine();
        }

        public string GetOpsystem()
        {
            return OP_system;
        }

        public void Print_mac_details()
        {
            print_computer_details();
            Console.WriteLine($"The software is {GetOpsystem()}");
        }
    }
}
