using System;

namespace HW5_PrinterProject
{
    public class PhotoPrinter: Printer
    {
        public override void Print(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Photo printer print: ");
            base.Print(argument);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine($"Photo printer own print: \n" +
                $"Photo size: '{photo.Size}';\n" +
                $"Black and white type: '{photo.BlackAndWhite}';\n" +
                $"And some wise parameter: '{photo.SomeWiseParameter}'.\n");
        }

    }
}
