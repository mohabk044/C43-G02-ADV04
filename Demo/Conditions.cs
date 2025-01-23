using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Conditions
    {
        public static bool CheckOdd(int number) { return number % 2 == 1; }
        public static bool CheckEven(int number) { return number % 2 == 0; }
        public static bool CheckDivisableBySeven(int number) { return number % 7 == 0; }

    }
}