using System;

namespace Exe
{
    interface Car
    {
        void Drive();

    }
         class Inherite:Car
    {
        void Car.Drive()
        {
            Console.WriteLine("Drive a Car "+"\n"+"Excute finish");
        }


        static void Main(string[] args)
        {
            //DemoObject.Drive();
            // Error: Cannot call explicitly implemented interface method
            // using the class object.
            // Type cast the demo object to interface type Car
            Inherite inherit_program = new Inherite();
            ((Car)inherit_program).Drive();
            
        }
    }
}
