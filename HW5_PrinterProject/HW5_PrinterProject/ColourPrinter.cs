using System;

namespace HW5_PrinterProject
{
    public class ColourPrinter: Printer
    {
        public override void Print(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Colour printer print: ");
            base.Print(argument);
        }

        public void Print (string argument, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Colour printer own print: \n{argument}.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
