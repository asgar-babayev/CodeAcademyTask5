using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Bicycle : Vehicle
    {
        public Bicycle()
        {
            Console.WriteLine("Bicycle yaradıldı");
        }
        public Bicycle(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime) : base(cycle, passangerCount, color, model, driveWay,driveTime)
        {
        }
        public void PrintBicycle()
        {
            Console.WriteLine($@"Model: {model}, Rəngi: {color}, Sərnişin sayı: {passangerCount}, 
Təkər sayı: {cycle}, Getdiyi yol: {driveWay} km, Getdiyi zaman: {driveTime} saat");
        }
    }
}
