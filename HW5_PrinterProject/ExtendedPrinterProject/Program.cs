using System;
using HW5_PrinterProject;

namespace ExtendedPrinterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer mainPrinter = new Printer();
            PhotoPrinter photoPrinter = new PhotoPrinter();
            ColourPrinter colourPrinter = new ColourPrinter();

            string[] mainArguments = { "First main test print", "Second main test print", "Third main test print" };
            Photo[] photos = { new Photo("100x100", true, 1), new Photo("200x200", false, 2), new Photo("300x300", true, 3) };
            string[] colourArguments = { "First colour test print", "Second colour test print", "Third colour test print" };
            ConsoleColor[] colors = { ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed };

            mainPrinter.ExtendedPrint(mainArguments);
            photoPrinter.ExtendedPhotoPrint(photos);
            colourPrinter.ExtendedColourPrint(colourArguments, colors);
        }
    }
}
