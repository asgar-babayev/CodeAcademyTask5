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

        }
        public Car(double motor)
        {
            this.motor = motor;
        }
    }
}
