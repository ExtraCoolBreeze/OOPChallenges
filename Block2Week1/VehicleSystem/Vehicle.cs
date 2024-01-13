using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSystem
{
    internal class Vehicle
    {
        protected int registration;
        protected string make;
        protected string colour;
        protected int year_manufactured;
        protected int wheel_size;

        public Vehicle()
        {
            registration = 0;
            make = "";
            colour = "";
            year_manufactured = 0;
            wheel_size = 0;
        }

        public void set_vehicle_details()
        {
            Console.Write("Enter registration: ");
            this.registration = int.Parse(Console.ReadLine());

            Console.Write("Enter make: ");
            this.make = Console.ReadLine();

            Console.Write("Enter colour: ");
            this.colour = Console.ReadLine();

            Console.Write("Enter year_manufactured: ");
            this.year_manufactured = int.Parse(Console.ReadLine());

            Console.Write("Enter wheel_size: ");
            this.wheel_size = int.Parse(Console.ReadLine());
        }

        public int Getregistration()
        {
            return registration;
        }

        public string GetMake()
        {
            return make;
        }

        public string Getcolour()
        {
            return colour;
        }
        public int Getyear_manufactured()
        {
            return year_manufactured;
        }
        public int Getwheel_size()
        {
            return wheel_size;
        }

        public void print_vehicle_details()
        {
            Console.WriteLine($"Registration is {Getregistration()}");
            Console.WriteLine($"Make is {GetMake()}");
            Console.WriteLine($"Colour is {Getcolour()}");
            Console.WriteLine($"Year manufactured is {Getyear_manufactured()}");
            Console.WriteLine($"Wheel size is {Getwheel_size()}");
        }
    }
}
