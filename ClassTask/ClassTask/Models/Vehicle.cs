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
        
        public void GetSpeed()
        {
            //S=v*t
            //v = S/t
            Console.WriteLine($"Getdiyi suret = {driveWay / driveTime}");
        }
    }
}
