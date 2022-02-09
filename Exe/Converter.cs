using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
   public static class Converter
    {
        public static double toFaranite(double celciouss)
        {
            return (celciouss * 9 / 5) + 32;
        }
        public static double toCelcious(double farhanitee)
        {
            return (farhanitee - 32) * 5 / 9;
        }
    }
}
