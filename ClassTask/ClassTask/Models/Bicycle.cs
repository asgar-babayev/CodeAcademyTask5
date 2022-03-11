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
        public Bicycle(int cycle)
        {
            this.cycle = cycle;
        }
        public Bicycle(int cycle, int passangerCount) : this(cycle)
        {
            this.passangerCount = passangerCount;
        }
        public Bicycle(int cycle, int passangerCount, string color) : this(cycle, passangerCount)
        {
            this.color = color;
        }
        public Bicycle(int cycle, int passangerCount, string color, string model) : this(cycle, passangerCount, color)
        {
            this.model = model;
        }

        public Bicycle(int cycle, int passangerCount, string color, string model, int driveWay) : this(cycle, passangerCount, color, model)
        {
            this.driveWay = driveWay;
        }
        public Bicycle(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime) : this(cycle, passangerCount, color, model, driveWay)
        {
            this.driveTime = driveTime;
        }
        public void PrintBicycle()
        {
            Console.WriteLine($@"Model: {model}, Rəngi: {color}, Sərnişin sayı: {passangerCount}, 
Təkər sayı: {cycle}, Getdiyi yol: {driveWay} km, Getdiyi zaman: {driveTime} saat");
        }
    }
}
