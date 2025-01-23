namespace Demo
{
    public delegate int StringFuncDelegate(string str);
    public delegate bool SortingTypesFuncDelegate<T>(T X, T Y);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate-Example1
            //StringFuncDelegate reference;
            //reference = new StringFuncDelegate(String_Functions.GetCountOfUpperCaseChars);
            //reference -= new StringFuncDelegate(String_Functions.GetCountOfLowerCaseChars);
            ////reference = String_Functions.GetCountOfUpperCaseChars; //Syntsx Sugar
            //int count = reference.Invoke("Mostafa MOHamed"); 
            //// int count = reference("Hello World"); //Syntsx Sugar
            //Console.WriteLine(count);
            #endregion

            #region Example02 
            //int[] Numbers = {4,5,2,1,3};
            ////SortingAlgorithms.BubbleSort(Numbers, SortingTypes.CompareGtr);
            ////foreach (int item in Numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine("******************************************");
            ////SortingAlgorithms.BubbleSort(Numbers , SortingTypes.CompareLss);
            ////foreach (int item in Numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine("******************************************");
            //SortingTypesFuncDelegate sortingType = SortingTypes.CompareGtr;
            //SortingAlgorithms.BubbleSort(Numbers,sortingType);
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Example 02 [With Generics]
            //string[] Names = {"Ali","Mostafa","Osama","Adel"};
            //SortingTypesFuncDelegate<string> sortingType = SortingTypes.SortAsc;
            //SortingAlgorithms<string>.BubbleSort(Names, sortingType);
            //foreach (string item in Names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Example 03 [With Generics]
            List<int> Odd = Enumerable.Range(0, 100).ToList();
            List<int> OddNumbers = Helper.FindNumbers(Odd, Conditions.CheckOdd);
            foreach (int item in OddNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            List<int> Even = Enumerable.Range(0, 100).ToList();
            List<int> EvenNumbers = Helper.FindNumbers(Even, Conditions.CheckEven);
            foreach (int item in EvenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            List<int> Divisable7 = Enumerable.Range(0, 100).ToList();
            List<int> NumbersDivisableBySeven = Helper.FindNumbers(Divisable7, Conditions.CheckDivisableBySeven);
            foreach (int item in NumbersDivisableBySeven)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}