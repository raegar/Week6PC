using System;
using System.Collections.Generic;
using System.Text;

namespace IntroOOP
{
    abstract class MotorVehicle
    {
        protected string make;
        protected string model;
        protected int speed = 0;
        protected int gear = 0;

        public MotorVehicle(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public virtual void Accelerate()
        {
            speed += gear;
        }

        public void Brake()
        {
            if (speed > 0)
            {
                speed -= 1;
            }
        }

        public void ChangeGearUp()
        {
            if (gear < 5)
            {
                gear++;
            }
        }

        public void ChangeGearDown()
        {
            if (gear > 0)
            {
                gear--;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make & model: {make} {model}");
            Console.WriteLine($"Current Speed: {speed}");
            Console.WriteLine($"Current Gear: {gear}");
        }
    }
}
