using System;
using System.Collections.Generic;
using System.Text;

namespace IntroOOP
{
    class Motorbike: MotorVehicle
    {
        bool hasSideCar;

        public Motorbike(bool hasSideCar, string make, string model):base(make, model)
        {
            this.hasSideCar = hasSideCar;
        }
        public void Wheelie()
        {
            Console.WriteLine("Pulling a Wheelie");
        }
    }
}
