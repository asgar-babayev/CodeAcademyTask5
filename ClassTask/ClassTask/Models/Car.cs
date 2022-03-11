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
        public Car(int cycle)
        {
            this.cycle = cycle;
        }
        public Car(int cycle, int passangerCount) : this(cycle)
        {
            this.passangerCount = passangerCount;
        }
        public Car(int cycle, int passangerCount, string color) : this(cycle, passangerCount)
        {
            this.color = color;
        }
        public Car(int cycle, int passangerCount, string color, string model) : this(cycle, passangerCount, color)
        {
            this.model = model;
        }

        public Car(int cycle, int passangerCount, string color, string model, int driveWay) : this(cycle, passangerCount, color, model)
        {
            this.driveWay = driveWay;
        }
        public Car(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime) : this(cycle, passangerCount, color, model, driveWay)
        {
            this.driveTime = driveTime;
        }

        public Car(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime, double motor) : this(cycle, passangerCount, color, model, driveWay, driveTime)
        {
            this.motor = motor;
        }
        public void PrintCar()
        {
            Console.WriteLine($@"Model: {model}, Rəngi: {color}, Motor gücü: {motor}, Sərnişin sayı: {passangerCount}, 
Təkər sayı: {cycle}, Getdiyi yol: {driveWay} km, Getdiyi zaman: {driveTime} saat");
        }
    }
}
