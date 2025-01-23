using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool ConditionsFuncDelegate(int number);
    internal class Helper
    {
        public static List<int> FindOddNumbers(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
        public static List<int> FindNumbersDivisableBySeven(List<int> numbers)
        {
            List<int> Result = new List<int>();
            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 7 == 0)
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
        public static List<int> FindNumbers(List<int> numbers, ConditionsFuncDelegate condition)
        {
            List<int> Result = new List<int>();
            if (numbers is not null && condition is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (condition.Invoke(numbers[i]))
                        Result.Add(numbers[i]);
                }
            }
            return Result;
        }
    }
}