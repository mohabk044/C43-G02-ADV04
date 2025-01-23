using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SomeFunctions
    {
        public static bool Test(int number) { return number > 0; }
        public static string Cast(int number) { return number.ToString(); }
        public static void Print(string name) { Console.WriteLine($"Hello {name}"); }
    }
}