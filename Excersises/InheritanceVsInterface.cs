using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersises
{
    public interface Car
    {
        void Drive();
       
        
    }
    class Demo : Car
    {
        void Car.Drive()
        {
            Console.WriteLine("Drive car");
        }


        public static void Main()
        {
            Demo demo_object = new Demo();
            ((Car)demo_object).Drive();

        }
    }
}
