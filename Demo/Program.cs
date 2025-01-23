namespace Demo
{
    public delegate int StringFuncDelegate(string str);
    public delegate bool SortingTypesFuncDelegate(int X, int Y);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate-Example1
            StringFuncDelegate reference;
            reference = new StringFuncDelegate(String_Functions.GetCountOfUpperCaseChars);
            reference -= new StringFuncDelegate(String_Functions.GetCountOfLowerCaseChars);
            //reference = String_Functions.GetCountOfUpperCaseChars; //Syntsx Sugar
            int count = reference.Invoke("Mostafa MOHamed");
            // int count = reference("Hello World"); //Syntsx Sugar
            Console.WriteLine(count);
            //StringFuncDelegate reference;
            //reference = new StringFuncDelegate(String_Functions.GetCountOfUpperCaseChars);
            //reference -= new StringFuncDelegate(String_Functions.GetCountOfLowerCaseChars);
            ////reference = String_Functions.GetCountOfUpperCaseChars; //Syntsx Sugar
            //int count = reference.Invoke("Mostafa MOHamed"); 
            //// int count = reference("Hello World"); //Syntsx Sugar
            //Console.WriteLine(count);
            #endregion

            #region Example02 
            int[] Numbers = { 4, 5, 2, 1, 3 };
            //SortingAlgorithms.BubbleSort(Numbers, SortingTypes.CompareGtr);
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("******************************************");
            //SortingAlgorithms.BubbleSort(Numbers , SortingTypes.CompareLss);
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("******************************************");
            SortingTypesFuncDelegate sortingType = SortingTypes.CompareGtr;
            SortingAlgorithms.BubbleSort(Numbers, sortingType);
            foreach (int item in Numbers)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}