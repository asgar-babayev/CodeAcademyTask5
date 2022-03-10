using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Bus : Vehicle
    {
        public double motor;
        public Bus()
        {

        }
        public Bus(double motor)
        {
            this.motor = motor;
        }
    }
}
