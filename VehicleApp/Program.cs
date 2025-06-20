using System;

namespace VehicleApp
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string colour, int year)
        {
            Make = make;
            Colour = colour;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Colour: {Colour}");
            Console.WriteLine($"Year: {Year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle("Toyota Yaris", "Red", 2020);
            myCar.DisplayInfo();

            Console.ReadLine();
        }
    }
}
