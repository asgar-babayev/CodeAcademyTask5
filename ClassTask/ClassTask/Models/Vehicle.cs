using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Vehicle
    {
        public int cycle;
        public int driveWay;
        public int passangerCount;
        public int driveTime;
        public string color;
        public string model;

        public Vehicle()
        {

        }
        public Vehicle(int cycle, int passangerCount, string color, string model)
        {
            this.cycle = cycle;
            this.passangerCount = passangerCount;
            this.color = color;
            this.model = model;
        }
        public Vehicle(int driveWay, int driveTime)
        {
            this.driveWay = driveWay;
            this.driveTime = driveTime;
        }

        public void GetSpeed()
        {
            //S=v*t
            //v = S/t
            Console.WriteLine($"Getdiyi suret = {driveWay / driveTime}");
        }

        public void Print()
        {
            Console.WriteLine($@"Model: {model}, Rengi: {color}, Sernishin sayi: {passangerCount}, 
Teker sayi: {cycle}, Getdiyi yol: {driveWay}, Getdiyi zaman: {driveTime}");
        }
    }
}
