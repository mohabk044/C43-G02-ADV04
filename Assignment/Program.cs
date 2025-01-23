namespace Assignment
{
    public delegate string BookFuncDelegate(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part2 - Q 01
            //Book myBook = new Book("Q123kndskj2", "To Kill a Mockingbird", "Harper Lee", new DateTime(2023, 5, 1), 350);
            //Console.WriteLine(myBook.ToString());
            #endregion

            #region Part 02 - Q 02 P.1

            //// Use the user-defined delegate
            //BookFuncDelegate myDelegate = BookFunctions.FindBookByTitle;
            //BookProcessor.ProcessBooks("To Kill a Mockingbird", myDelegate);
            #endregion

            #region Part 02 - Q 02 P.2
            Func<string, string> myDelegate = BookFunctions.FindBookByTitle;
            Console.WriteLine(myDelegate.Invoke("To Kill a Mockingbird"));
            #endregion
        }
    }
}