using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ArrayWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass mainArray = new ArrayClass(1, 2, "qwerty", 25, true, "ololo");
            mainArray.PrintArray();

            mainArray.Add("test", 25, 42);
            mainArray.PrintArray();

            var check1 = mainArray.GetByIndex(6);
            var check2 = mainArray.GetByIndex(25);
            Console.WriteLine($"Check1 value: '{check1}'; Check2 value: '{check2}'.");

            //checks
            mainArray.Contains("qwerty");
            mainArray.Contains(1);
            mainArray.Contains(true);
            mainArray.Contains(3);
            mainArray.Contains("olololololo");
            mainArray.Contains(false);
        }
    }
}
