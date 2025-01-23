using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        public static string? GetTitle(Book book)
        {
            return book.Title;
        }

        public static string? GetAuthors(Book book)
        {
            return book.Authors;
        }

        public static decimal GetPrice(Book book)
        {
            return book.Price;
        }
    }
}