using System;

namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(false, "Ford", "Fiesta");
            Motorbike bike1 = new Motorbike(false, "Yamaha", "R1");
   
            //MotorVehicle mv = new MotorVehicle("Sinclair", "C5"); // MotorVehicles are not objects!

            car1.DisplayDetails();
            car1.ChangeGearUp();
            car1.Accelerate();
            car1.Accelerate();
            car1.DisplayDetails();

            

            //Can you add more cars and make them do things?
            //Can you add a motorbike and make it do things?
            //Can you create another vehicle type and an instance of this?
        }
    }
}
