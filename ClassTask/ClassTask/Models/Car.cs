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
        

        public Car(int cycle, int passangerCount, string color, string model, int driveWay, int driveTime, double motor) : base(cycle, passangerCount, color, model, driveWay, driveTime)
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
