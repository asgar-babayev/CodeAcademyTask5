using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Bicycle : Vehicle
    {
        public Bicycle(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime)
        {
            this.cycle = cycle;
            this.passangerCount = passangerCount;
            this.color = color;
            this.model = model;
            this.driveWay = driveWay;
            this.driveTime = driveTime;
        }
        public void PrintBicycle()
        {
            Console.WriteLine($@"Model: {model}, Rəngi: {color}, Sərnişin sayı: {passangerCount}, 
Təkər sayı: {cycle}, Getdiyi yol: {driveWay}, Getdiyi zaman: {driveTime}");
        }
    }
}
