using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Vehicle
    {
        public int cycle;
        public double driveWay;
        public int passangerCount;
        public int driveTime;
        public string color;
        public string model;

        public Vehicle()
        {

        }
        public Vehicle(int cycle)
        {
            this.cycle = cycle;
        }
        public Vehicle(int cycle, int passangerCount) : this(cycle)
        {
            this.passangerCount = passangerCount;
        }
        public Vehicle(int cycle, int passangerCount, string color) : this(cycle, passangerCount)
        {
            this.color = color;
        }
        public Vehicle(int cycle, int passangerCount, string color, string model) : this(cycle, passangerCount, color)
        {
            this.model = model;
        }

        public Vehicle(int cycle, int passangerCount, string color, string model, int driveWay) : this(cycle, passangerCount, color, model)
        {
            this.driveWay = driveWay;
        }
        public Vehicle(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime) : this(cycle, passangerCount, color, model, driveWay)
        {
            this.driveTime = driveTime;
        }

        public void GetSpeed()
        {
            Console.WriteLine($"Getdiyi suret = {driveWay / driveTime}");
        }
    }
}
