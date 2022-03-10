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
            Car car = new Car(4, 4, "Qara", "BMW", 100, 2, 2.5);
            car.PrintCar();
            car.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Avtobus üçün çıxarılan nəticə...");
            Bus bus = new Bus(6, 20, "Qırmızı", "Daewoo", 120, 4, 2.2);
            bus.PrintBus();
            bus.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Velosiped üçün çıxarılan nəticə...");
            Bicycle bicycle = new Bicycle(2,1,"Göy","Road Bike",30,2)
            {
                color = "Göy", model = "Road Bike", cycle = 2, passangerCount = 1, driveWay = 30, driveTime = 2
            };
            bicycle.PrintBicycle();
            bicycle.GetSpeed();
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
