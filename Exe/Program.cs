using System;

namespace Exe
{

         class Calculation
    {
      


        static void Main(string[] args)
        {
            double celcious = 37;
            double  farhanite = 98.6;
            Console.WriteLine("Value of Faranite to Celcious is",
            //the below Converter word is the static class name and we will acess the method using the class name.
            Converter.toCelcious(farhanite));
            Console.WriteLine("value for celcious to faranite is ",
            Converter.toFaranite(celcious));



        }
    }
}
