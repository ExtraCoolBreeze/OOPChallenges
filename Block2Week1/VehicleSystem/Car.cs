using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    class Car : Vehicle
    {
        private int num_of_seats;

        public Car()
        {
            num_of_seats = 0;
        }

        public void Setnum_of_seats()
        {
            set_vehicle_details();

            Console.Write("Enter number of seats: ");
            this.num_of_seats = int.Parse(Console.ReadLine());
        }

        public int Getnum_of_seats()
        {
            return num_of_seats;
        }

        public void Print_num_of_seats()
        {
            print_vehicle_details();
            Console.WriteLine($"The software is {Getnum_of_seats()}");
        }
    }
}
