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
            Converter.toCelcious(farhanite));
            Console.WriteLine("value for celcious to faranite is ",

            Converter.toFaranite(celcious));



        }
    }
}
