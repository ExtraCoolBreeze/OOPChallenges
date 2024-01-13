using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Van : Vehicle
    {
        private int loading_space;

        public Van()
        {
            loading_space = 0;
        }

        public void Setloading_space()
        { 
            set_vehicle_details();

            Console.Write("Enter loading_space: \n");
            Console.Write("1. Large: \n");
            Console.Write("2. Medium: \n");
            Console.Write("3. Small: \n");
            Console.Write("Enter your choice: ");
            this.loading_space = int.Parse(Console.ReadLine());
        }

        public int Getloading_space()
        {
            return loading_space;
        }

        public void Print_loading_space()
        {
            print_vehicle_details();
            Console.WriteLine($"The software is {Getloading_space()}");
        }
    } 
}
