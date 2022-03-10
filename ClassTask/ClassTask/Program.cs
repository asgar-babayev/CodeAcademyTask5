using System;
using ClassTask.Models;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Maşın üçün çıxarılan nəticə...");
            Car car = new Car()
            {
                color = "Qara", model = "BMW", cycle = 4, passangerCount = 4, motor = 2.5, driveWay = 100, driveTime = 2
            };
            car.Print();
            car.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Avtobus üçün çıxarılan nəticə...");
            Bus bus = new Bus()
            {
                color = "Qirmizi", model = "Daewoo", cycle = 6, passangerCount = 20, motor = 2.2, driveWay = 120, driveTime = 4
            };
            bus.Print();
            bus.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Velosiped üçün çıxarılan nəticə...");
            Bicycle bicycle = new Bicycle()
            {
                color = "Göy", model = "Road Bike", cycle = 2, passangerCount = 1, driveWay = 30, driveTime = 2
            };
            bicycle.Print();
            bicycle.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
