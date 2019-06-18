using System;

namespace HW5_PrinterProject
{
    public class Printer
    {
        public virtual void Print(string argument)
        {
            Console.WriteLine($"{argument}\n");
        }
    }
}
