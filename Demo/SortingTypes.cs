using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingTypes
    {
        public static bool SortAsc(string X, string Y) { return X?.Length > Y?.Length; } // Sorting in Ascending Order
        public static bool SortDes(string X, string Y) { return X?.Length < Y?.Length; } // Sorting in Descending Order
        public static bool CompareGtr(int X, int Y) { return X > Y; } // Sorting in Ascending Order
        public static bool CompareLss(int X, int Y) { return X < Y; } // Sorting in Descending Order
    }
}