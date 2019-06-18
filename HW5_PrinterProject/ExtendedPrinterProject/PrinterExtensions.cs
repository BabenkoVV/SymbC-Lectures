using System;
using HW5_PrinterProject;
namespace ExtendedPrinterProject
{
    public static class PrinterExtensions
    {
        public static void ExtendedPrint(this Printer printer, string[] arguments)
        {
            foreach (string str in arguments)
            {
                printer.Print(str);
            }
        }

        public static void ExtendedPhotoPrint(this PhotoPrinter photoPrinter, Photo[] photos)
        {
            foreach (Photo ph in photos)
            {
                photoPrinter.Print(ph);
            }
        }

        public static void ExtendedColourPrint(this ColourPrinter colourPrinter, string[] arguments, ConsoleColor[] colors)
        {
            foreach (ConsoleColor col in colors)
            {
                foreach(string arg in arguments)
                {
                    colourPrinter.Print(arg, col);
                }
            }
        }
    }
}
