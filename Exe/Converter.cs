using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
   public static class Converter
    {
        public static double toFaranite(double celcious)
        {
            return (celcious * 9 / 5) + 32;
        }
        public static double toCelcious(double farhanite)
        {
            return (farhanite - 32) * 5 / 9;
        }
    }
}
