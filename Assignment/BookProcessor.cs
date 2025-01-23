using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookProcessor
    {
        public static void ProcessBooks(string parameter, BookFuncDelegate bookMethod)
        {
            string result = bookMethod(parameter);
            Console.WriteLine(result);
        }
    }
}