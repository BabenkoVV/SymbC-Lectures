using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ArrayWrap
{
    class ArrayClass
    {
        public object[] ArrayWrap { get; set; }

        public ArrayClass(params object[] i)
        {
            ArrayWrap = i;
        }

        public bool CheckIndex(int index)
        {
            if(ArrayWrap.Length<(index+1))
            {
                Console.WriteLine("Error! Index is out of array range.");
                return false;
            }
            else
            {
                Console.WriteLine("Index is in array range.");
                return true;
            }
        }

        public object GetByIndex(int index)
        {
            object result = (CheckIndex(index)) ? ArrayWrap[index] : null;
            return result;
        }

        public bool Contains(object value)
        {
            bool result = (ArrayWrap.Contains(value)) ? true : false;
            return result;
        }

        public void Add(params object[] addValue)
        {
            this.ArrayWrap = ArrayWrap.Concat(addValue).ToArray();
        }

        public void PrintArray()
        {
            Console.WriteLine("Prined array:");
            foreach (object i in ArrayWrap)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }

        



    }
}
