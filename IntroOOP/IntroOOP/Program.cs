using System;

namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(false, "Ford", "Fiesta");

            car1.DisplayDetails();
            car1.ChangeGearUp();
            car1.Accelerate();
            car1.Accelerate();
            car1.DisplayDetails();

        }
    }
}
