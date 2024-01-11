using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_InventorySystem
{
    class Computer
    {
      protected int computer_id;
      protected string make;
      protected string model;
      protected string memory_size;
      protected string Hard_disk_size;
      protected string Processor;


        public Computer()
        {
            computer_id = 0;
            make = "";
            model = "";
            memory_size = "";
            Hard_disk_size = "";
            Processor = "";
        }

        public void set_comp_details()
        {
            Console.Write("Enter computer id: ");
            this.computer_id = int.Parse(Console.ReadLine());

            Console.Write("Enter make: ");
            this.make = Console.ReadLine();

            Console.Write("Enter model: ");
            this.model = Console.ReadLine();

            Console.Write("Enter memory size: ");
            this.memory_size = Console.ReadLine();

            Console.Write("Enter Hard disk size: ");
            this.Hard_disk_size = Console.ReadLine();

            Console.Write("Enter Processor: ");
            this.Processor = Console.ReadLine();
        }

        public int Getid()
        {
            return computer_id;
        }

        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model;
        }
        public string GetMemory()
        {
            return memory_size;
        }
        public string GetHD()
        {
            return Hard_disk_size;
        }
        public string GetProcessor()
        {
            return Processor;
        }

        public void print_computer_details()
        {
            Console.WriteLine($"Computer id is {Getid()}");
            Console.WriteLine($"Make is {GetMake()}");
            Console.WriteLine($"Model is {GetModel()}");
            Console.WriteLine($"Memory size is {GetMemory()}");
            Console.WriteLine($"Hard disk size is {GetHD()}");
            Console.WriteLine($"Processor is {GetProcessor()}");
        }
    }
}
