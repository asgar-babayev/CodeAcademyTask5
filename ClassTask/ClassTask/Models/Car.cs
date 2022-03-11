using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Car : Vehicle
    {
        public double motor;

        public Car()
        {
            Console.WriteLine("Car yaradıldı");
        }
        public Car(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime, double motor)
        {
            this.cycle = cycle;
            this.passangerCount = passangerCount;
            this.color = color;
            this.model = model;
            this.driveWay = driveWay;
            this.driveTime = driveTime;
            this.motor = motor;
        }
        public void PrintCar()
        {
            Console.WriteLine($@"Model: {model}, Rəngi: {color}, Motor gücü: {motor}, Sərnişin sayı: {passangerCount}, 
Təkər sayı: {cycle}, Getdiyi yol: {driveWay}, Getdiyi zaman: {driveTime}");
        }
    }
}
