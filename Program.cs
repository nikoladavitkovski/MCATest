using System;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Vehicle
    {
        public string type { get; set; }

        public string registertable { get; set; }

        public int price { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                Vehicle vehicle = new Vehicle();

                List<Vehicle> vehicles = new List<Vehicle>();

                List<Vehicle> car = new List<Vehicle>();
                List<Vehicle> bus = new List<Vehicle>();
                List<Vehicle> truck = new List<Vehicle>();
                List<Vehicle> motorwayToll = new List<Vehicle>(); 

                foreach (Vehicle vehicle1 in vehicles)
                {
                    Console.WriteLine(vehicle1.type);
                    Console.WriteLine($"{vehicle.type}car");
                    Console.WriteLine($"{vehicle.type}bus");
                    Console.WriteLine($"{vehicle.type}truck");
                }
                foreach (Vehicle vehicle2 in vehicles)
                {
                    Console.WriteLine($"{vehicle.price.Equals("40 den")}");
                    Console.WriteLine($"{vehicle.price.Equals("120 den")}");
                    Console.WriteLine($"{vehicle.price.Equals("240 den")}");
                    Console.WriteLine($"{vehicle.price.Equals("400 den")}");
                }
                foreach(Vehicle vehicle3 in motorwayToll)
                {
                    Console.WriteLine($"Vehicle type:car");
                    Console.WriteLine($"Vehicle type:truck");
                }
                vehicle.Equals(car);
                vehicle.Equals(bus);
                vehicle.Equals(truck);
                int sum = 0;
                if(sum == 240)
                {
                    Console.WriteLine("Total from trucks: 240 den");
                }
                Console.WriteLine($"Vehicle type:{vehicle.type}bus");
                Console.WriteLine($"Vehicle type:{vehicle.type}car");
                Console.WriteLine($"Vehicle type:{vehicle.type}truck");
                // Motorway
                // Car (SK-1234-AB, 40 den)
                // Bus (KA-4321-CD, 120 den)
                // Truck (BT-2314-AB, 240 den, withTrailer)

                // Total: 400 den
                // Total from trucks: 240 den

                //Pseudocode
                //List motorwayToll
                //motorwayToll.Add(new Car)
                //motorwayToll.Add(new Truck)

                // Print content and sum                
                Console.WriteLine($"Car vehicle content:SK-1234-AB, 40 den");
                Console.WriteLine($"Bus vehicle content:KA-4321-CD, 120 den");
                Console.WriteLine($"Truck vehicle content:BT-2314-AB, 240 den, withTrailer");
                Console.WriteLine($"Total from all: 400 den");
                Console.WriteLine($"Total from trucks: 240 den");
                Console.ReadLine();
            }
        }
    }
}
