using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalogsObject = new Catalog();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split('/');

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int finalParam = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car cars = new Car(brand, model, finalParam);

                    catalogsObject.Cars.Add(cars);
                    
                }

                if (type == "Truck")
                {
                    Truck trucks = new Truck(brand, model, finalParam);

                    catalogsObject.Trucks.Add(trucks);
                }

                command = Console.ReadLine();
            }

            List<Car> orderedCars = catalogsObject.Cars.OrderBy(car => car.Brand).ToList();

            if (orderedCars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            List<Truck> orderedTrucks = catalogsObject.Trucks.OrderBy(truck => truck.Brand).ToList();

            if (orderedTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
