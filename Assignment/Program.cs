namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part2 - Q 01
            Book myBook = new Book("Q123kndskj2", "To Kill a Mockingbird", "Harper Lee", new DateTime(2023, 5, 1), 350);
            Console.WriteLine(myBook.ToString());
            #endregion
        }
    }
}