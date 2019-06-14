using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 4, 8, 2, 9, 3, 7, 2, 6 };

            Console.WriteLine("Array before sort: ");
            PrintArr(testArr);

            Sort(testArr);

            Console.WriteLine("\nArray after sort: ");
            PrintArr(testArr);
        }

        public static void Sort(params int[] testArr)
        {
            for (int i = 0; i < testArr.Length - 1; i++)
            {
                for (int j = i + 1; j < testArr.Length; j++)
                {
                    if (testArr[i] > testArr[j])
                    {
                        var temp = testArr[i];
                        testArr[i] = testArr[j];
                        testArr[j] = temp;
                    }
                }
            }
        }

        public static void PrintArr(params int[] testArr)
        {
            foreach (var i in testArr)
            {
                Console.Write($"{i} \t");
            }
        }


    }
}
