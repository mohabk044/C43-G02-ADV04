namespace Demo
{
    internal class Program
    {
        public delegate int StringFuncDelegate(string str);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Delegate-Example1
            StringFuncDelegate reference;
            reference = new StringFuncDelegate(String_Functions.GetCountOfUpperCaseChars);
            reference -= new StringFuncDelegate(String_Functions.GetCountOfLowerCaseChars);
            //reference = String_Functions.GetCountOfUpperCaseChars; //Syntsx Sugar
            int count = reference.Invoke("Mostafa MOHamed");
            // int count = reference("Hello World"); //Syntsx Sugar
            Console.WriteLine(count);
            #endregion
        }
    }
}
