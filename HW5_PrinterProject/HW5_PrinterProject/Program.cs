using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_PrinterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer mainPrinter = new Printer();
            ColourPrinter colourPrinter = new ColourPrinter();
            PhotoPrinter photoPrinter = new PhotoPrinter();
            Photo photo = new Photo("128x145", false, 42);

            mainPrinter.Print("Test string.");
            colourPrinter.Print("Colour test string.");
            photoPrinter.Print("Photo test print.");

            colourPrinter.Print("Second colour test string", ConsoleColor.DarkRed);
            photoPrinter.Print(photo);
        }
    }
}
