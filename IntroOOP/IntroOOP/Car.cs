using System;
using System.Collections.Generic;
using System.Text;

namespace IntroOOP
{
    class Car: MotorVehicle
    {
        bool isConvertible;

        public Car(string make, string model)
        {
            this.isConvertible = isConvertible;
        }

        public Car(bool isConvertible, string make, string model)
        {
            this.isConvertible = isConvertible;
        }

        public void Reverse()
        {
            Console.WriteLine("Reversing");
        }
    }
}
