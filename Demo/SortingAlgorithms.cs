using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] arr, SortingTypesFuncDelegate<T> sortingType)
        {
            if (arr is not null && sortingType is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (sortingType.Invoke(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        private static void Swap(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
    }
}