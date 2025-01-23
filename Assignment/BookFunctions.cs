using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        #region Q1 
        //public static string? GetTitle(Book book)
        //{
        //    return book.Title;
        //}

        //public static string? GetAuthors(Book book)
        //{
        //    return book.Authors;
        //}

        //public static decimal GetPrice(Book book)
        //{
        //    return book.Price;
        //} 
        #endregion

        #region Q2
        public static string FindBookByTitle(string title)
        {
            return $"The book is : {title}";
        }
        #endregion
    }
}